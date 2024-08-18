# Diol. Example 2 - AspNET Endpoint Logging Sample

## Description

This document provides a concise and straightforward demonstration of `Diol`, a powerful logging tool for Visual Studio. 

The guide is designed to be completed in approximately **5 minutes**, making it a quick and easy way to familiarize yourself with Diol’s capabilities. 

The steps are **clear** and **simple**, requiring no specific prior knowledge. 

Whether you’re a seasoned developer or a beginner, this guide offers a practical introduction to incorporating `Diol` into your projects for enhanced logging.

## Todo

### 1. Install DIOL from marketplace

* Open your Visual Studio (minimal version **17.11.x** VS 2022)
* Go to `Extensions` -> `Manage Extensions`
* Search for `Diol` and install it
* Go to `View` -> `Other windows` -> `Diol`

### 2. Setup the project locally

* Clone the repository
* Open `Diol.Demo` solution in Visual Studio
* In `Solution Explorer` find `Example2AspnetEndpointLoggingSample` project and right click on it. 
* Select `Set as StartUp Project`

### 3. Setup logging for AspNET endpoints 

* Call search panel by pressing `CTRL` + `F`
* In searching category select `Current project`
* As a search value type `TODO`
* You should see 3 items (2 in `Program.cs` and 1 in `appsettings.development.json`)
* Uncomment things from `TODO` **1** till `TODO` **4** (`TODO` **5** will be done in advanced section)
* `TODO` **1** is in `Program.cs` file: Register logging for `AspNET`
* `TODO` **2** is in `Program.cs` file: Add logging middleware for a request pipeline
* `TODO` **3** is in `appsettings.development.json`: Setup logs filter for `AspNET`

### 4. Run the project and check DIOL

* Press `F5` to run the project
* Return to Visual Studio and open `Diol` window
* Return to the browser and refresh the page
* Call an endpoint from `swagger` page
* Refresh the browser
* Return to Visual Studio and check the logs in `Diol` window
* Click on the log and check the details
* Stop the project

### 5. Advanced section

* Run the project again
* Play with different endpoints from `swagger` page
* Refresh the browser
* Return to Visual Studio and check the logs in `Diol` window
* Click on the log and check the details
* Compare endpoints content and logs you see in `Diol` (like headers, body, query, etc.)
* Stop the project

### Well done!

Congratulations on completing the Diol AspNET Endpoint Logging Sample!

## 6. Summary

In just a few minutes, you’ve accomplished the following:

* **Installation**: You’ve successfully installed `Diol` from the Visual Studio Marketplace.
* **Project Setup**: You’ve cloned the repository and set up the `Diol.Demo` solution locally.
* **Configuration**: You’ve configured an AspNET endpoint logging in the project.
* **Execution**: You’ve run the project, utilized the `Diol` window for log analysis.
* **Advanced Exploration**: You’ve engaged with various endpoints, compared content, and analyzed detailed logs in `Diol`.

This hands-on guide has provided you with a solid foundation to leverage Diol for effective logging in your future AspNET projects. 

Remember, efficient logging is crucial for development and debugging, and Diol streamlines this process.

## Show Your Support

If you found this guide helpful and Diol useful, we’d love to hear from you! 

Your feedback helps us improve and continue to deliver quality content. 

Please consider taking a moment to:
* Like and comment on [our Visual Studio Marketplace page](https://marketplace.visualstudio.com/items?itemName=Diol.diol) 
* Star our [main Diol repository on GitHub](https://github.com/Dotnet-IO-logger/core) 

Your support means a lot to us and contributes to the open-source community.