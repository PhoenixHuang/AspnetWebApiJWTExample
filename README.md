# AspnetWebApiJWTExample
An example of asp.net web API using JWT

# Step1
Create an webapi asp.net web project
```
Install-Package Microsoft.AspNet.WebApi -Version 5.2.2
Install-Package Microsoft.AspNet.WebApi.Owin -Version 5.2.2
Install-Package Microsoft.Owin.Host.SystemWeb -Version 3.0.0
Install-Package Microsoft.Owin.Cors -Version 3.0.0
Install-Package Microsoft.Owin.Security.OAuth -Version 3.0.0
Install-Package System.IdentityModel.Tokens.Jwt -Version 4.0.0
Install-Package Thinktecture.IdentityModel.Core Version 1.2.0
```
# Step 2
Add the Owin Startup class, Startup.cs

# Step 3
Add customformat class

# Step 4
Add customprovider class

# Step 5
Add Authorize attribute to the API you need to protect
