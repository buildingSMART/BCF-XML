# Decomposed objects

This test case verifies support for correct handling of decomposed objects, such as, curtain walls.

## Testing process

1. Load _Architectural.ifc_ from the test cases root directory
2. Import BCF file
3. Verify the bcfzip was imported correctly.
> Topic with guid 28942812-8783-4d92-9c54-8a8f31937975 has all other parts of wall 2_hQ1Rixj6lgHTra$L72O4 but one plate visible. The guid of the plate that should be hidden is: 14rw$C3xD3ZeUJL3YaqCEK.

4. Export the topic(s) you imported to _exported.bcf_.
5. Verify that no information was lost during the export.

