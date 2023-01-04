# Private_Keys_Depot_WindowsForms

This sample project demonstrates Private Keys Depot and a custom .NET Windows Forms application integration.
It shows how to create a Private Key, get all Keys and modify them, and then delete a specified Key in the Depot.

A usual problem for developers is managing secret keys used to protect communication between applications and services. 
Skater Private Keys that are managed identically, rule out the need for developers to manipulate with these credentials.
App developers can safely add the keys into Skater Private Keys Depot, and then apps can access Skater Private Keys Depot
to retrieve stored credentials. Managed Private Keys Depot provide an automatically managed secret Key in Skater Private
Keys Depot for applications to use when connecting to specific resources. Applications can use managed Skater Depot to
obtain Keys without having to manage any credentials.

To make reference to Skater.Cloud.Vault.dll use this command within the Package Manager Console in Visual Studio:
NuGet\Install-Package Skater.Cloud.Vault -Version 1.9.1.3

## KeysDepot Class

The following methods of KeysDepot class from Skater.Cloud.Vault namespace need to be utilized to manage keys from Skater
Private Keys Depot: 

```
getCertificate (string CertificateIV)
```
- Get Certificate details associated with user registration account                                                            
---
```
getKeys (string CertificateIV)
```
- Get all keys associated with Depot registered account
---
```
getKey (string CertificateIV, string KeyName)
```
- Get all fields of a specified Key
---
```
dropKey (string CertificateIV, string KeyName)
```
- Delete Key from Depot
---
```
checkKey (string CertificateIV, string KeyName, string Key)
```
- Check Key by comparing its value against an external entered value
---
```
updateKey (string CertificateIV, string KeyName, string Key, string Description, string Password, string cryptoAlgorithm)
```
- Update Key that already exist in Keys Depot
---
```
addKey (string CertificateIV, string KeyName, string Key, string Description, string Password, string cryptoAlgorithm)
```
- Add new Key into Skater Private Keys Depot
---
To get the Certificate IV (Initialization Vector) you need to access your online Skater Keys Depot account.


## DepotKey Class

There is an additional DepotKey data structure class in Skater.Cloud.Vault namespace. The structure contents the following 
public properties: 
```
KeyName As String           
```
- Name identifier of the Key. The Name uniquely identifies a key in Private Keys Depot. 
\
Must be no longer than 128 characters. Accepts alphanumeric characters and the _ char only. 
\
The names must be unique and do not start with a number.
---
```
KeyDescription As String    
```
- Description of the Key. Optional parameter.
\
Must be no longer than 512 characters.
---
```
Key As String               
```
- Key. The value cryptographically encoded. Must be no longer than 1024 characters.
---
```
cryptoPassword As String    
```
- Key's password of cryptographic encryption for internal system usage. Must be no longer than 128 characters.
---
```
cryptoAlgorithm As String   
```
- Key's cryptographic algorithm name. The algorithm is used to encrypt data and provide confidentiality.
\
Depot offers to select an algorithm that will be used for Key encryption. Take one of 3 listed algorithm names:
\
"Symmetric Block Cipher - AES-256", 
\
"Three-Key Triple DES", or 
\
"Hash Functions - SHA-256"
---
```
created_at As DateTime      
```
- Date and time when the Key first created. Read-only, system generated value
---
```
updated_at As DateTime      
```
- Date and time when the Key last updated. Read-only, system generated value
---

The structure is useful to specify a key. That defined key then can be easily added, modified, and read to/from Keys Depot.

## Certificate Class

There is Certificate data structure class in Skater.Cloud.Vault namespace. The structure contents the following public properties
\
```
RegistrationID As String
```
- Registration ID: a unique identifier is an alphanumeric string occurs when users register for Private Keys Depot
---
```
- CertificateOwner As String
```
- Person or an organization who registered for Skater Private Keys Depot license
---
```
EmailAddress As String
```
- Certificate Owner's email address. Can be used as a registration User Name
---
```
LicenseeAddress As String
```
- Certificate Owner's post address. Optional, can be kept empty
---
```
LicensedDate As DateTime
```
- When Skater Private Keys Depot account has been registered
---
```
Status As String
```
- License status
---
Use the Certificate structure when you call getCertificate() method.
\
Also there is ```IList<string>``` collection of cryptographic algorithm names in DepotKey class. The collection is useful to specify which one of 3 types algorithm you would like to utilize for your key cryptography.
\
\
[Learn more about the Skater.Cloud.Vault](http://rustemsoft.com/SkaterDoc/#skater_depot)

#### Copyright © Rustemsoft LLC
