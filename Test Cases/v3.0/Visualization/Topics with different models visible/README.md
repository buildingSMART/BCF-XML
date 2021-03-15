# Topics with different models visible

This test case verifies support for correct handling of which models should be visible when displaying a viewpoint.

## Testing process

1. Load _Architectural.ifc_ and _MEP.ifc_ from the test cases root directory.
2. Import the bcf file.
3. Verify the bcfzip was imported correctly:

> Topic named "Topics with different model visible - MEP" should only display the MEP model when visualized.
> Topic named "Topics with different model visible - Architectural" should only display the Architectural model when visualized.

4. Export the topic(s) you imported to _exported.bcf_.
5. Verify that no information was lost during the export.

