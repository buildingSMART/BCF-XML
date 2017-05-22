# Orthogonal Camera

This test case verifies support of a BCFzip file that contains a single viewpoint with an orthogonal camera.

## Testing process

1. Import _OrthogonalCamera.bcfzip_.
2. Verify the bcfzip was imported correctly:
> 1. There is one topic within the zip file:
> > Orthogonal Camera - 97881cb2-6462-4161-8d57-3d179b280755
> 2. Verify that all information can be processed.

3. Export the topic you imported to _exported.bcfzip_.
4. Verify that no information was lost during the export