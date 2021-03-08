# Decomposed objects

This test case verifies support for correct handling of decomposed objects, such as, curtain walls. In this test case only the parent component of a decomposed curtain wall is listed in the components part of the viewpoint.bcfv. 

## Testing process

1. Load _Architectural.ifc_ from the test cases root directory
2. Import _Decomposed object with parent guid.bcfzip_
3. Verify the bcfzip was imported correctly:

> 1. Topic with guid a23e8824-137a-4bea-a1ad-541f87d274e7 should have all parts of decomposed wall (2_hQ1Rixj6lgHTra$L72O4) visible 

4. Export the topic(s) you imported to _exported.bcfzip_
5. Verify that no information was lost during the export

## (Optional) special notes

No special notes 

