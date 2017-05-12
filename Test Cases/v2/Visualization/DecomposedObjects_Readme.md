# Decomposed objects

This test case verifies support for correct handling of decomposed objects, such as, curtain walls.

## Testing process

1. Load _Architectural.ifc_ from the test cases root directory
2. Import _Decomposed objects.bcfzip_
3. Verify the bcfzip was imported correctly:

> 1. Topic with guid 6da43897-f4ff-4694-97dc-fc4a43770749 should have all parts of decomposed wall (2_hQ1Rixj6lgHTra$L72O4) visible 
> 2. Topic with guid 24e5625c-8ff1-40f9-81f2-f31cfa48cf74 has all other parts of wall 2_hQ1Rixj6lgHTra$L72O4 but the middle plate  visible. The guid of the plate that should be hidden is: 28Fol_2rT8D93IPNMW2ztB 
> 3. Topic with guid eb59ce15-5713-47ed-8505-ccccd91b4170 shows only one part of the decomposed wall. The guid of the visible plate is 14rw$C3xD3ZeUJL3YaqCEK 

4. Export the topic(s) you imported to _exported.bcfzip_
5. Verify that no information was lost during the export

## (Optional) special notes

No special notes 

