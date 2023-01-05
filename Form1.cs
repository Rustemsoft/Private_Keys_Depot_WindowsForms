/// Private_Keys_Depot_WindowsForms
/// 
/// This sample project demonstrates Private Keys Depot and a custom .NET Windows Forms application integration.
/// It shows how to create a Private Key, get all Keys and modify them, and then delete a specified Key in the Depot.
/// 
/// A usual problem for developers is managing secret keys used to protect communication between applications and services. 
/// Skater Private Keys that are managed identically, rule out the need for developers to manipulate with these credentials.
/// App developers can safely add the keys into Skater Private Keys Depot, and then apps can access Skater Private Keys Depot
/// to retrieve stored credentials. Managed Private Keys Depot provide an automatically managed secret Key in Skater Private
/// Keys Depot for applications to use when connecting to specific resources. Applications can use managed Skater Depot to
/// obtain Keys without having to manage any credentials.
/// 
/// The following methods of KeysDepot class from Skater.Cloud.Vault namespace need to be utilized to manage keys from Skater
/// Private Keys Depot: 
/// getCertificate(string CertificateIV)                        - Get Certificate details associated with user registration account                                                            
/// getKeys(string CertificateIV)                               - Get all keys associated with Depot registered account
/// getKey(string CertificateIV, string KeyName)                - Get all fields of a specified Key
/// dropKey(string CertificateIV, string KeyName)               - Delete Key from Depot
/// checkKey(string CertificateIV, string KeyName, string Key)  - Check Key by comparing its value against an external entered value
/// updateKey(string CertificateIV, string KeyName, string Key, string Description, string Password, string cryptoAlgorithm)
///                                                             - Update Key that already exist in Keys Depot
/// addKey(string CertificateIV, string KeyName, string Key, string Description, string Password, string cryptoAlgorithm)
///                                                             - Add new Key into Skater Private Keys Depot
/// To get the Certificate IV (Initialization Vector) you need to access your online Skater Keys Depot account.
/// 
/// There is an additional DepotKey data structure class in Skater.Cloud.Vault namespace. The structure contents the following 
/// public properties: 
/// KeyName As String           Name identifier of the Key. The Name uniquely identifies a key in Private Keys Depot. 
///                             Must be no longer than 128 characters. Accepts alphanumeric characters and the _ char only. 
///                             The names must be unique and do not start with a number.
/// KeyDescription As String    Description of the Key. Optional parameter.
///                             Must be no longer than 512 characters.
/// Key As String               Key. The value cryptographically encoded.
///                             Must be no longer than 1024 characters.
/// cryptoPassword As String    Key's password of cryptographic encryption for internal system usage.
///                             Must be no longer than 128 characters.
/// cryptoAlgorithm As String   Key's cryptographic algorithm name. The algorithm is used to encrypt data and provide confidentiality.
///                             Depot offers to select an algorithm that will be used for Key encryption. Take one of 3 listed algorithm names:
///                             "Symmetric Block Cipher - AES-256", 
///                             "Three-Key Triple DES", or 
///                             "Hash Functions - SHA-256"
/// created_at As DateTime      Date and time when the Key first created.
///                             Read-only, system generated value
/// updated_at As DateTime      Date and time when the Key last updated. 
///                             Read-only, system generated value
/// The structure is useful to specify a key. That defined key then can be easily added, modified, and read to/from Keys Depot.
/// 
/// There is Certificate data structure class in Skater.Cloud.Vault namespace. The structure contents the following public properties: 
/// RegistrationID As String    Registration ID: a unique identifier is an alphanumeric string occurs when users register for Private Keys Depot
/// CertificateOwner As String  Person or an organization who registered for Skater Private Keys Depot license
/// EmailAddress As String      Certificate Owner's email address. Can be used as a registration User Name
/// LicenseeAddress As String   Certificate Owner's post address. Optional, can be kept empty
/// LicensedDate As DateTime    When Skater Private Keys Depot account has been registered
/// Status As String            License status
/// Use the Certificate structure when you call getCertificate() method.
/// 
/// Also there is IList<string> collection of cryptographic algorithm names in DepotKey class. The collection is useful to specify
/// which one of 3 types algorithm you would like to utilize for your key cryptography.
/// 
/// To make reference to Skater.Cloud.Vault.dll use this command within the Package Manager Console in Visual Studio:
/// NuGet\Install-Package Skater.Cloud.Vault -Version 1.9.1.3
/// 
/// Copyright © Rustemsoft LLC

using System.Collections.Generic;
using System.Windows.Forms;
using Skater.Cloud.Vault;

namespace Private_Keys_Depot_WindowsForms
{
    public partial class Form1 : Form
    {
        IList<string> algorithms = new List<string>();
        public Form1()
        {
            InitializeComponent();
            algorithms = KeysDepot.DepotKey.cryptoAlgorithms();
            BindingSource bs = new BindingSource();
            bs.DataSource = algorithms;
            cbxAlg.DataSource = bs;

            /*//======================================================================
            /// Let's suggest you have the following code that updating a SQL Server table records.
            string sql_Query = "UPDATE MY_TABLE SET FLAG_FIELD = 1;";
            string dBConnectionString = "Persist Security Info=False; User Id=UserName; Password=SecretPassword; Initial Catalog=MY_DATABASE; Data Source = ServerName;";
            using (SqlConnection conn = new SqlConnection(dBConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql_Query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            /// The most vulnerable element, in terms of the possibility of a hacker attack, is of course the dBConnectionString connection string.
            /// It contains secret data about connection to SQL Server. It must be cryptographically encoded and then securely hidden by storing to
            /// a cloud server. By using Skater Private Keys Depot you can easily accomplish that. Suppose you have certificate IV associated with 
            /// your registered account: CERTIFICATE_IV. To get the Certificate IV (a cryptographic initialization vector) you need to access your 
            /// online Skater Private Keys Depot account and copy the IV. Also you have previously stored the key named CONNECTION_STRING_KEY 
            /// in the Keys Depot. You stored the CONNECTION_STRING_KEY Key value as
            /// "Persist Security Info=False; User Id=UserName; Password=SecretPassword; Initial Catalog=MY_DATABASE; Data Source = ServerName;"
            /// So the above code that updating a SQL Server table can be modified as shown below:
            Skater.Cloud.Vault.DepotKey depotKey = Skater.Cloud.Vault.KeysDepot.getKey("CERTIFICATE_IV", "CONNECTION_STRING_KEY");
            if (depotKey != null)
            {
                string sql_Query = "UPDATE MY_TABLE SET FLAG_FIELD = 1;";
                string dBConnectionString = depotKey.Key; // Connection String replaced with the depot's retrieved Key
                using (SqlConnection conn = new SqlConnection(dBConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql_Query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            *///=======================================================================
        }

        // Get all fields of a specified Key
        private void btnGetKey_Click(object sender, System.EventArgs e)
        {
            string text = "";
            richTextBox1.Text = string.Empty;
            if (txbxCertificateIV.Text == string.Empty)
            {
                MessageBox.Show("Enter parameter!");
                return;
            }

            if (txbxKeyName.Text == "")
            {
                IEnumerable<KeysDepot.DepotKey> depotKeys = KeysDepot.getKeys(txbxCertificateIV.Text);
                if (depotKeys == null)
                {
                    MessageBox.Show("No any key stored!");
                    return;
                }
                foreach (KeysDepot.DepotKey depotKey in depotKeys)
                {
                    text += depotKey.KeyName + ": " + depotKey.Key + "\n\rDescription: " + depotKey.KeyDescription + "\n\rCrypto Password: " + depotKey.cryptoPassword + "\n\rCrypto Algorithm: " + depotKey.cryptoAlgorithm + "\n\rCreated at: " + depotKey.created_at.ToString() + "\n\rUpdated at: " + depotKey.updated_at.ToString();
                    text += "\n\r------------------------------------------------------------\n\r";
                }
            }
            else
            {
                KeysDepot.DepotKey depotKey = KeysDepot.getKey(txbxCertificateIV.Text, txbxKeyName.Text);
                if (depotKey == null)
                {
                    MessageBox.Show("No such key stored!");
                    return;
                }
                text = depotKey.KeyName + ": " + depotKey.Key + "\n\rDescription: " + depotKey.KeyDescription + "\n\rCrypto Password: " + depotKey.cryptoPassword + "\n\rCrypto Algorithm: " + depotKey.cryptoAlgorithm + "\n\rCreated at: " + depotKey.created_at.ToString() + "\n\rUpdated at: " + depotKey.updated_at.ToString();
                txbxKey.Text = depotKey.Key;
                txbxDescr.Text = depotKey.KeyDescription;
                txbxPsw.Text = depotKey.cryptoPassword;
                cbxAlg.Text = depotKey.cryptoAlgorithm;
            }
            richTextBox1.Text = text;
        }

        private void txbxKeyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGetKey.PerformClick();
        }

        // Get all keys associated with Depot registered account
        private void btnGetKeys_Click(object sender, System.EventArgs e)
        {
            string text = txbxKeyName.Text;
            txbxKeyName.Text = "";
            btnGetKey.PerformClick();
            txbxKeyName.Text = text;
        }

        // Delete Key from Depot
        private void btnDropKey_Click(object sender, System.EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            if (txbxCertificateIV.Text == string.Empty || txbxKeyName.Text == string.Empty)
            {
                MessageBox.Show("Enter parameters!");
                return;
            }

            string key = KeysDepot.dropKey(txbxCertificateIV.Text, txbxKeyName.Text);
            if ((key ?? "") != "")
            {
                richTextBox1.Text = key;
            }
        }

        // Check Key by comparing its value
        private void btnCheckKey_Click(object sender, System.EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            if (txbxCertificateIV.Text == string.Empty || txbxKeyName.Text == string.Empty || txbxKey.Text == string.Empty)
            {
                MessageBox.Show("Enter parameters!");
                return;
            }

            bool result = KeysDepot.checkKey(txbxCertificateIV.Text, txbxKeyName.Text, txbxKey.Text);
            richTextBox1.Text = (result ? "Yes, key match" : "No, doesn't match");
        }

        // Update Key
        private void btnUpdKey_Click(object sender, System.EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            if (txbxCertificateIV.Text == string.Empty || txbxKeyName.Text == string.Empty || txbxKey.Text == string.Empty ||
                txbxDescr.Text == string.Empty || txbxPsw.Text == string.Empty || cbxAlg.Text == string.Empty)
            {
                MessageBox.Show("Enter parameters!");
                return;
            }
            richTextBox1.Text = KeysDepot.updateKey(txbxCertificateIV.Text, txbxKeyName.Text, txbxKey.Text,txbxDescr.Text, txbxPsw.Text, cbxAlg.Text);
        }

        // Create Key
        private void btnAddKey_Click(object sender, System.EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            if (txbxCertificateIV.Text == string.Empty || txbxKeyName.Text == string.Empty || txbxKey.Text == string.Empty ||
                txbxDescr.Text == string.Empty || txbxPsw.Text == string.Empty || cbxAlg.Text == string.Empty)
            {
                MessageBox.Show("Enter parameters!");
                return;
            }
            richTextBox1.Text = KeysDepot.addKey(txbxCertificateIV.Text, txbxKeyName.Text, txbxKey.Text, txbxDescr.Text, txbxPsw.Text, cbxAlg.Text);
        }

        // Get Certificate Details
        private void btnCerificate_Click(object sender, System.EventArgs e)
        {
            string text = "";
            richTextBox1.Text = string.Empty;
            if (txbxCertificateIV.Text == string.Empty)
            {
                MessageBox.Show("Enter parameter!");
                return;
            }

            Skater.Cloud.Vault.KeysDepot.Certificate cert = Skater.Cloud.Vault.KeysDepot.getCertificate(txbxCertificateIV.Text);
            text = "Certificate Owner: " + cert.CertificateOwner + "\n\rRegistration ID: " + cert.RegistrationID + "\n\rStatus: " + cert.Status +
                   "\n\rEmail Address: " + cert.EmailAddress + "\n\rLicensee Address: " + cert.LicenseeAddress + "\n\rLicensed Date: " + cert.LicensedDate.ToShortDateString();
            richTextBox1.Text = text;
        }
    }
}
