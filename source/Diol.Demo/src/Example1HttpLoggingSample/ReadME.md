# Diol. Example 1 - Http Logging Sample

## Description

This document provides a concise and straightforward demonstration of `Diol`, a powerful HTTP logging tool for Visual Studio. 

The guide is designed to be completed in approximately **5 minutes**, making it a quick and easy way to familiarize yourself with Diol’s capabilities. 

The steps are **clear** and **simple**, requiring no specific prior knowledge. 

Whether you’re a seasoned developer or a beginner, this guide offers a practical introduction to incorporating `Diol` into your projects for enhanced HTTP logging.

## Todo

### 1. Install DIOL from marketplace

* Open your Visual Studio (minimal version **17.11.x** VS 2022)
* Go to `Extensions` -> `Manage Extensions`
* Search for `Diol` and install it
* Go to `View` -> `Other windows` -> `Diol`

### 2. Setup the project locally

* Clone the repository
* Open `Diol.Demo` solution in Visual Studio
* In `Solution Explorer` find `Example1HttpLoggingSample` project and right click on it. 
* Select `Set as StartUp Project`

### 3. Setup httpClient and logs 

* Call search panel by pressing `CTRL` + `F`
* In searching category select `Current project`
* As a search value type `TODO`
* You should see 5 items (4 in `Program.cs` and 1 in `appsettings.development.json`)
* Uncomment things from `TODO` **1** till `TODO` **4** (`TODO` **5** will be done in advanced section)
* `TODO` **1** is in `Program.cs` file: Register `HttpClient`
* `TODO` **2** is in `Program.cs` file: Make a http call to an external service
* `TODO` **3** is in `Startup.cs` file: Return a status code to a client
* `TODO` **4** is in `appsettings.development.json`: Setup logs filter for `HttpClient`

### 4. Run the project and check DIOL

* Press `F5` to run the project
* Return to Visual Studio and open `Diol` window
* Return to the browser and refresh the page
* Call `Bing` endpoint from `swagger` page
* Refresh the browser
* Return to Visual Studio and check the logs in `Diol` window
* Click on the log and check the details
* Stop the project

### 5. Advanced section

* Find `TODO` **5** in `Program.cs` and uncomment it
* Run the project again
* Call `Bing` endpoint from `swagger` page
* Refresh the browser
* Return to Visual Studio and check the logs in `Diol` window
* Click on the log and check the details
* Check the `Request headers` section
* Stop the project

### Well done!

Well done on successfully navigating through this quick demonstration!

## 6. Summary

 
You’ve not only installed Diol and set up a local project, but also configured an HttpClient and delved into HTTP logs using Diol’s user-friendly interface. 

This hands-on experience has equipped you with the practical knowledge to further explore and utilize Diol in your future projects. 

Remember, effective logging is an integral part of software development and debugging, and Diol makes this process significantly more streamlined and efficient.

## Show Your Support

If you found this guide helpful and Diol useful, we’d love to hear from you! 

Your feedback helps us improve and continue to deliver quality content. 

Please consider taking a moment to:
* Like and comment on [our Visual Studio Marketplace page](https://marketplace.visualstudio.com/items?itemName=Diol.diol) 
* Star our [main Diol repository on GitHub](https://github.com/Dotnet-IO-logger/core) 

Your support means a lot to us and contributes to the open-source community.