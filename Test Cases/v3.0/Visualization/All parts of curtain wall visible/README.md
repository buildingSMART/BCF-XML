# Decomposed objects

This test case verifies support for correct handling of decomposed objects, such as, curtain walls.

## Testing process

1. Load _Architectural.ifc_ from the test cases root directory.
2. Import the bcf file.
3. Verify the bcfzip was imported correctly:

> Topic with guid ee9a9498-698b-44ed-8ece-b3ae3b480a90 should have all parts of decomposed wall (2_hQ1Rixj6lgHTra$L72O4) visible.

4. Export the topic(s) you imported to _exported.bcf_.
5. Verify that no information was lost during the export.

