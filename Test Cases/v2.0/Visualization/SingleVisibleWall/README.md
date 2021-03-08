# Single Visible Wall

This test case verifies support for component visibility settings

## Testing process

1. Load _Architectural.ifc_ from the test cases root directory
2. Import _single_visible_wall.bcfzip_
4. Verify the bcfzip was imported correctly:

> 1. Verify that single wall in _components_ is visible
> 2. Verify that nothing else is visible

4. Export the topic(s) you imported to _exported.bcfzip_
5. Verify that no information was lost during the export