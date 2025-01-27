### Clean Archtecture  - Basic Cutomer Info. Portal - .Net Core 8.0 API & Mud Blazor UI.

Thanks for the opportunity.

Below shared the steps for Local setup, Architecture and Technology/packages used. Please take a look and let me know if any suggestions,

## ----------***Run Locally***------------

**Step 1 - Database Setup**
- AWS Login URI - [Click](https://eu-north-1.signin.aws.amazon.com/oauth?client_id=arn%3Aaws%3Asignin%3A%3A%3Aconsole%2Fcanvas&code_challenge=-m26WQEkVqwsCg763QAYC_Z6rt9OUnppe0_lYUnlgck&code_challenge_method=SHA-256&response_type=code&redirect_uri=https%3A%2F%2Fconsole.aws.amazon.com%2Fconsole%2Fhome%3FhashArgs%3D%2523%26isauthcode%3Dtrue%26nc2%3Dh_ct%26oauthStart%3D1721843669849%26src%3Dheader-signin%26state%3DhashArgsFromTB_eu-north-1_d5317d597a5dba4e)
- *Create **DynamoDB** table,*
  ```bash
  Table Name - customers
  ```

- *Create **AWS Profile** online and Set it up locally using below command and add profile details in config file.*
    ```bash
    aws configure --profile "ProfileName"
 
 
**Step 2 - Clone/download *[API Respos](https://github.com/rcadirvele/CleanArchitecture.CustomerInfoAPI.git)* and Open CleanArchitecture.CustomerInfo.API.sln, then Build and Run the API.**

- API Swagger URI - https://localhost:20909/swagger/index.html
    
    ***Note:*** I have included the above URI as a BaseAddress in Blazor Web app.


**Step 3 - Clone/download *[UI Respos](https://github.com/rcadirvele/CleanArchitecture.CustomerInfoUI.git)* and Open CleanArchitecture.CustomerInfoInfo.BlazorWasmUI.sln, then Build and Run the Blazor UI.**
- Blazor URI - https://localhost:7167

    ***Note:*** I have included above URI in API CORS.


## -----------***Tech Stack***---------------
### Architecture/Approach -

As software design approrach, followed ***Clean Architecture*** - 

    * Core Layer - CleanArchitecture.CustomerInfo.Application.Core.csproj
        * Application
        * Domain
    * Infrastructure Layer - CleanArchitecture.CustomerInfo.Infrastructure.csproj
    * Presentation Layer 
        * API - CleanArchitecture.CustomerInfo.API.csproj
        * UI  - CleanArchitecture.CustomerInfo.BlazorWasmUI
    
    Unit test: CleanArchitecture.CustomerInfo.Test.csproj

#### Technologies used - 

***Client/UI -*** 

- [Blazor](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-8.0) Web Assembly with [MudBlzor](https://mudblazor.com/) Components.
    
    **Version** - Asp .Net Core 8.0 .
  
***API technology/packages used -*** 
- .Net Core 8.0 Web API 
- **Validation** - Fluent Validation
- **Logging** - Serilog (File logging & provision for Aws Cloudwatch)
- **Unit Test** - NUnit & Moq as Mock framework.

***Database -*** AWS Cloud DynamoDB *(Provided in setup Instruction).*

I have included all of my approach as i understood.

*****Thanks for the opportunity. Feel free to provide any suggestion. Looking forward to discuss more!*****

 
 
 
 
 ***ToDo*** *- Detailed validation to cover all cases, some UI and include additional features if any.*
