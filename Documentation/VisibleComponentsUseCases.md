# Components: Typical Use Cases
This document lists various typical use cases of components in viewpoints. In cases 1 to 4 the assumption is that the model has more components than spaces.
## Case 1: All components visible, all spaces and openings hidden
* DefaultVisibility: true
* component_list: empty
* spaces_on: false
* openings_on: false
* space_boundaries_on: false

## Case 2: Two components visible, everything else invisible
* DefaultVisibility: false
* component_list: the two components
* spaces_on: false
* openings_on: false
* space_boundaries_on: false

## Case 3: Two components and one space visible, everything else invisible
* DefaultVisibility: false
* component_list: the two components and the space
* spaces_on: false
* openings_on: false
* space_boundaries_on: false

## Case 4: All components visible and one space visible, everything else invisible
* DefaultVisibility: true
* component_list: the hidden spaces
* spaces_on: true
* openings_on: false
* space_boundaries_on: false

## Case 5: Model with only spaces: All spaces visible
* DefaultVisibility: false
* component_list: empty
* spaces_on: true
* openings_on: false
* space_boundaries_on: false

## Case 6: Model with only spaces: One space visible
* DefaultVisibility: false
* component_list: one visible space
* spaces_on: false
* openings_on: false
* space_boundaries_on: false

## Case 7: Model with only spaces: One space hidden, rest visible
* DefaultVisibility: true
* component_list: one hidden space
* spaces_on: true
* openings_on: false
* space_boundaries_on: false

## Case 8: Normal model: Only walls visible (1000 walls out of 50000 components (incl. spaces))
* DefaultVisibility: false
* component_list: 1000 walls
* spaces_on: false
* openings_on: false
* space_boundaries_on: false

