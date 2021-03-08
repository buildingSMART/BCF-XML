# Extension Schema

This test case verifies support of an embedded extension schema withing a BCFZip file.

## Testing process

1. Import _ExtensionSchema.bcfzip_.
2. Verify the bcfzip was imported correctly:
> 1. Your application is aware of the relative reference to _extensions.xsd_ as given in the _ProjectExtension_'s _ExtensionSchema_ property in the _project.bcfp_ file.
> 2. The values within the _extensions.xsd_ are imported into your application's issue management interface and presented as selectable choices to the user upon creation of new issues.
> 3. There is a single topic within the file that only has a minimum amount of information. The information should be recognized as being in compliance to the project's extension schema.

3. Export the topic you imported to _exported.bcfzip_.
4. Verify that no information was lost during the export