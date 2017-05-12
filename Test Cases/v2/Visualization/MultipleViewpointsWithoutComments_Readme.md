# multiple viewpoints without comments

This test case verifies support for multiple viewpoints without comments in the viewpoint

## Testing process

1. Load _Architectural.ifc_ from the test cases root directory
2. Import _multiple_viewpoints_without_comments.bcfzip_
3. Verify the bcfzip was imported correctly:

> Verification paragrpah 1
> 1. Bcfzip file has one issue with six viewpoint (Model from six sides)
> 2. The viewpoint no 3 is initially visible
> 3. There are no comments with any viewpoint

> Verification paragrpah 2 

4. Export the topic(s) you imported to _exported.ifc_
5. Verify that no information was lost during the export

## (Optional) special notes

This is an optional section 

