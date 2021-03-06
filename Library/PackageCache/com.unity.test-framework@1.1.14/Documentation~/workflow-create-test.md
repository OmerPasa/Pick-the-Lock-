                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                # Workflow: How to create a test

To create a test, do the following:

1. Create your *Test* [assembly folder](./workflow-create-test-assembly.md) and select it in the **Project** window.
2. Click the button **Create Test Script in current folder** option in the **Test Runner** window.

![EditMode create test script](./images/editmode-create-test-script.png)

3. It creates a *NewTestScript.cs* file in the *Tests* folder. Change the name of the script, if necessary, and press Enter to accept it. 

![NewTestScript.cs](./images/new-test-script.png)

Now you’ll see two sample tests in the Test Runner window:

![Test templates](./images/test-templates.png)

Now you can open the tests in your favorite script editor.

You can also create test scripts by navigating to **Assets** > **Create > Testing** > **C# Test Script**, unless adding a test script would result in a compilation error.

> **Note**: Unity does not include `TestAssemblies` ([NUnit](http://www.nunit.org/), Unity Test Framework, and user script assemblies) when using the normal build pipeline, but does include t