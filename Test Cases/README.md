# Test Case Instructions

This folder contains test cases for testing BCF file exchange. Each test case should meet the following requirements:

* Simplicity: Test case should test one thing at a time
* Completeness: All necessary files need (e.g. IFC and BCFZIP) files need to be available
* Documentation: Document describing the test case must be provided, preferably with images

To provide test cases, create a fork of the repository, commit your test cases there and create a pull request.

The test cases are divided in the following folders depending on their primary focus:

* Markup: Test cases that mainly deal with textual information, Title, Description, Comments, etc.
* Visualization: Test Cases that deal with visualization
* Project: Examples of using extension schema
* Real world: Examples of real world test cases

Each test case has a folder adjacent to it with the same name as the _.bcf / .bcfzip_ file. This folder contains the
unzipped content of the BCF zip archive.

## Automated Checking

This repository includes a tool that runs automatic checks against all test cases in the `Test Cases` folder. To run this tool, run the following command in a shell on the root level of this repository:

    ./build.cmd CheckTestCases

The command will work on any operating system, but first runs might take a few minutes to download required dependencies. Errors will be logged to the console output.

Claudio Benghi (@CBenghi) wrote the tool that checks the test cases. It is available at: https://github.com/CBenghi/bcf-tool
