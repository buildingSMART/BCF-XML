# Default component visibility

This test case verifies support for the default visibility rules of components based on the implementation agreement specified in the BCF 2.0 specification.  

## Testing process

1. Load _Architectural.ifc_ from the test cases root directory
2. Import _default-component-visibility.bcfzip_
3. Verify the bcfzip was imported correctly:

> 1. IfcWallStandardCase with GUID _1E8YkwPMfB$h99jtn_uAjI_ should be selected
> 2. IfcSpace with GUID _1m5wAJelDFdhn6qBdOGjos_ should not be visible 
> 3. IfcSpace with GUID _1bbI761TbBCOoIa5Kt6PXt_ should not be visible 
> 
> In short, all spaces and openings should be made invisible by default when there is no visibility specification in the bcfzip  

4. Export the topic(s) you imported to _exported.bcfzip_
5. Verify that no information was lost during the export
6. Verify that the viewpoint doesn't include any visible/invisible elements


