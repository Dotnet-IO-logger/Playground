# Diol. Example 3 - EntityFramework Logging Sample

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
* In `Solution Explorer` find `Example3EntityFrameworkLoggingSample` project and right click on it. 
* Select `Set as StartUp Project`
* Open a terminal in the project directory (not the Solution directory)
* Run `dotnet ef database update` to create a database

### 3. Setup logging for EntityFramework 

* Call search panel by pressing `CTRL` + `F`
* In searching category select `Current project`
* As a search value type `TODO`
* You should see one item (in `appsettings.development.json`)
* Uncomment things from `TODO` **1**
* `TODO` **1** is in `appsettings.development.json`: Setup logs filter for `EntityFramework`

### 4. Run the project and check DIOL

* Press `F5` to run the project
* Return to Visual Studio and open `Diol` window
* Return to the browser and refresh the page
* Find endpoints from `TODOs`: 2, 3 and 4
* Call an endpoint from `swagger` page
* Refresh the browser
* Return to Visual Studio and check the logs in `Diol` window
* Click on the log and check the details
* Try another endpoints from `TODOs`: 2, 3 and 4. Compare a LINQ expression and final SQL query
* Stop the project

### 5. Advanced section

* Run the project again
* Find endpoints from `TODOs`: 5, 6, 7 and 8
* Try endpoints from `swagger` page
* Refresh the browser
* Return to Visual Studio and check the logs in `Diol` window
* Click on the log and check the details
* Learn how `Diol` can help you with LINQ expressions and SQL queries such as joins, group by, where, transactions, etc.
* Stop the project

### Well done!

Congratulations on completing the Diol EntityFramework Logging Sample!

## 6. Summary

In this guide, you’ve achieved the following:

* **Installation**: You’ve successfully installed Diol from the Visual Studio Marketplace.
* **Project Setup**: You’ve cloned the repository and set up the Diol.Demo solution locally.
* **Configuration**: You’ve configured EntityFramework logging in the project by updating the `appsettings.development.json` and uncommenting the necessary sections.
* **Execution**: You’ve run the project, interacted with various endpoints, and utilized the Diol window for log analysis.
* **Advanced Exploration**: You’ve engaged with different endpoints, analyzed LINQ expressions and SQL queries, and learned how Diol can help you with complex database operations.

This hands-on guide has provided you with a practical understanding of how to leverage Diol for effective logging in your future EntityFramework projects.

Remember, efficient logging is essential for development and debugging, and Diol simplifies this process, especially when working with databases and EntityFramework.

## Show Your Support

If you found this guide helpful and Diol useful, we’d love to hear from you! 

Your feedback helps us improve and continue to deliver quality content. 

Please consider taking a moment to:
* Like and comment on [our Visual Studio Marketplace page](https://marketplace.visualstudio.com/items?itemName=Diol.diol) 
* Star our [main Diol repository on GitHub](https://github.com/Dotnet-IO-logger/core) 

Your support means a lot to us and contributes to the open-source community.