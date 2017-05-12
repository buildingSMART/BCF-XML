# Maximum Information

This test case verifies support of a BCFzip file that contains all information available in the schema.

## Testing process

1. Import _MaximumInformation.bcfzip_.
2. Verify the bcfzip was imported correctly:
> 1. There are two topics within the zip file:
> > Maximum Content - 63E78882-7C6A-4BF7-8982-FC478AFB9C97
> > Referenced topic - 5019D939-62A4-45D9-B205-FAB602C98FE8
> 2. Verify that all information can be processed.

3. Export the topic you imported to _exported.bcfzip_.
4. Verify that no information was lost during the export