# Perspective Camera

This test case verifies support of a BCFzip file that contains a single viewpoint with a perspective camera.

## Testing process

1. Import _PerspectiveCamera.bcfzip_.
2. Verify the bcfzip was imported correctly:
> 1. There is one topic within the zip file:
> > Perspective Camera - 3153ceb9-0d9b-4f89-9670-dc95768836af
> 2. Verify that all information can be processed.

3. Export the topic you imported to _exported.bcfzip_.
4. Verify that no information was lost during the export