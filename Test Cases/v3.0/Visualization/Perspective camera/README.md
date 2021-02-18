# Perspective Camera

This test case verifies support of a BCF file that contains a single viewpoint with a perspective camera.

## Testing process

1. Import the BCF file.
2. Verify the bcfzip was imported correctly:
> 1. There is one topic within the zip file with a perspective camera viewpoint.
> 2. Verify that all information can be processed.
3. Export the topic you imported.
4. Verify that no information was lost during the export.