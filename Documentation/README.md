# BIM Collaboration Format v2.0 Technical Documentation
![BCF](https://github.com/BuildingSMART/BCF/blob/master/Icons/BCFicon128.png?raw=true "The BCF logo")

Authors:

* Pasi Paasiala, Solibri (BCF 1.0 / BCF 2.0)
* Juha Laukala, Tekla (BCF 1.0)
* Lassi Lifländer, Tekla (BCF 1.0)
* Klaus Linhard, IABI (BCF 2.0)
* Erik Pijnenburg, Kubus (BCF 2.0)
* Léon van Berlo, TNO (BCF 2.0)

### Terms and Abbreviations

GUID
Globally Unique Identifier: http://en.wikipedia.org/wiki/Globally_Unique_Identifier
IfcGuid
Globally Unique ID in the IFC format. This format is used only when referring to components in IFC files.


|       |           |  
| ------------- |:-------------|
| BCF      | BIM Collaboration Format |
| BCF file     | File in BIM Collaboration Format     |
| Topic | One topic, such as a problem in the design, described in BCF file    |
| GUID |Globally Unique Identifier: http://en.wikipedia.org/wiki/Globally_Unique_Identifier

### Background
* This document describes the BCF format that is used to exchange topics, such as, issues, scenes, etc. between different BIM software.

### BCF file structure
A BCF file is a zip containing one folder for each topic. The root of the BCF zip contains the following files.

* project.bcfp (optional)
    - An XML file referencing the extension.xsd to a project. The schema for this file is project.xsd.
* bcf.version
	* An XML file following the version.xsd schema with information of the BCF schema used. The file content should be identical to the contents of [bcf.version](bcf.version "bcf.version")

The folder name is the GUID of the topic. This GUID is in the UUID form. The folder contains the following files:

* markup.bcf
    * An XML file following the markup.xsd schema that is described below.
* viewpoint.bcfv
    * An XML file following the visinfo.xsd schema that is described below (for compatibility with BCF 1.0).
    * Multiple viewpoints are possible in BCF 2.0. Names of these files are not predefined. Note: One viewpoint needs to be be named viewpoint.bcfv even in the case of multiple viewpoints.
* snapshot.png 
    *  A snapshot related to the topic (for compatibility with BCF 1.0).
Multiple snapshots are possible in BCF 2.0. Names of these files are not predefined. Note: One snapshot needs to be named snapshot.png even in the case of multiple viewpoints.


*Note: The elements in the XML files must appear in the order given in the schemas and described below.*

## Project (.bcfp) file

The project file contains reference information about the project the topics belong to.


### Project
Project node contains information about the name of the project. 


 Attribute | Optional | Description |  
:-----------|:------------|:------------:
 ProjectId  |        Yes |     ProjectId of the project
 
### ExtensionSchema
URI to the extension schema. 


## Markup (.bcf) file
The markup file contains textual information about the topic.

### Header
Header node contains information about the IFC files relevant to this topic. It has one attribute, ProjectGuid, which is the project GUID. Header has also a list of File nodes.

Each File node has the following attributes:


 Attribute | Optional | Description |  
:-----------|:------------|:------------
 IfcProject  |        Yes |     IfcGuid Reference to the project to which this topic is related in the IFC file
IfcSpatialStructureElement | Yes | IfcGuid Reference to the spatial structure element, e.g. IfcBuildingStorey, to which this topic is related.
isExternal | Yes | Is the IFC file external or within the bcfzip. (Default = true).

In addition File has the following nodes:

 Attribute | Optional | Description |  
:-----------|:------------|:------------
Filename | Yes | The BIM file related to this topic.
Date | Yes | Date of the BIM file.
Reference | Yes | URI to IfcFile. <br> IsExternal=false “..\example.ifc“ (within bcfzip) <br> IsExternal=true  “https://.../example.ifc“

### Topic
Topic node contains reference information of the topic. It has one attribute, Guid, which is the topic GUID. 


 Attribute | Optional | Description |  
:-----------|:------------|:------------
Guid | Yes | Guid of the topic
TopicType | Yes | Type of the topic (Predefined list in “extension.xsd”)

In addition it has the following nodes:


 Element | Optional | Description |  
:-----------|:------------|:------------
Title | No | Title of the topic.
Guid | No | The topic identifier
ReferenceLink | Yes | Reference to the topic in, for example, a work request management system.
Description | Yes | Description of the topic
Priority | Yes | Topic priority. The list of possible values are defined in the extension schema
Index | Yes | Number to maintain the order of the topics.
CreationDate | Yes | Date when the topic was created
CreationAuthor | Yes | User who created the topic
ModifiedDate | Yes | Date when the topic was last modified
ModifiedAuthor | Yes | User who modified the topic
AssignedTo | Yes | The user to whom this topic is assigned to
TopicType | Yes | The type of the topic (the options can be specified in the extension schema)
TopicStatus | Yes | The status of the topic (the options can be specified in the extension schema)


### BimSnippet (optional)
BimSnippet is an additional file containing information related to one or multiple topics. For example, it can be an IFC file containing provisions for voids.

 Attribute | Optional | Description |  
:-----------|:------------|:------------
SnippetType | No | Type of the Snippet (Predefined list in “extension.xsd”)
IsExternal | Yes | Is the BimSnippet external or within the bcfzip. <br> (Default = false).
 
 Element | Optional | Description |  
:-----------|:------------|:------------
Reference | No | URI to BimSnippet. <br> IsExternal=false  “..\snippetExample.ifc“ (within bcfzip) <br> IsExternal=true  “https://.../snippetExample.ifc“
ReferenceSchema | Yes | URI to BimSnippetSchema (always external)


### DocumentReference (optional)
DocumentReference provides a means to associate additional payloads or links with topics. The references may point to a file within the .bcfzip or to an external location.

Attribute | Optional | Description |  
:-----------|:------------|:------------
Guid | Yes | Guid attribute for identifying it uniquely
IsExternal | Yes | Is the Document external or within the bcfzip. <br> (Default = false).

 Element | Optional | Description |  
:-----------|:------------|:------------
ReferencedDocument | Yes | URI to document. <br> IsExternal=false  “..\exampleDoc.docx“ (within bcfzip) <br> IsExternal=true  “https://.../ exampleDoc.docx“
Description | Yes | Description of the document


### RelatedTopics (optional)
Relation between topics (Clash -> PfV -> Opening)


### Comment
The markup file can contain comments related to the topic. Their purpose is to record discussion between different parties related to the topic. Comment has also the Guid attribute for identifying it uniquely. In addition, it has the following nodes:

Element | Optional | Description |  
:-----------|:------------|:------------
VerbalStatus | Yes | A free text status. The options for this can be agreed, for example, in a project.
Status | No | Status of the comment / topic (Predefined list in “extension.xsd”)
Date | No | Date of the comment
Author |No | Comment author
Comment | No | The comment text
Topic | No | Back reference to the topic GUID.
ReplyToComment | Yes | Guid of the comment to which this comment is a reply
ModifiedDate | Yes | The date when comment was modified
ModifiedAuthor | Yes | The author who modified the comment

### Viewpoints
The markup file can contain multiple viewpoints related to one or more comments. A viewpoint has also the Guid attribute for identifying it uniquely. In addition, it has the following nodes:

Element | Optional | Description |  
:-----------|:------------|:------------
Viewpoint | Yes | Filename of the viewpoint (.bcfv)
Snapshot | Yes | Filename of the snapshot(.png)
Comment | Yes | Back reference to the comment GUID.


## Visualization information (.bcfv) file
The visualization information file contains information of components related to the topic, camera settings, and possible markup and clipping information.

### Components
The components node contains a set of Component references. The numeric values in this file are all given in fixed units (meters for length and degrees for angle). Unit conversion is not required, since the values are not relevant to the user. 

Components has the following attributes:

Attribute | Optional | Description |  
:-----------|:------------|:------------
IfcGuid | Yes | Select the component in a BIM tool
Selected | Yes | This flag is true if the component is actually involved in the topic. If the flag is false, the component is involved as reference.
Visible | Yes | This flag is true when the component is visible in the visualization. By setting this false, you can hide components that would prevent seeing the topic from the camera position and angle of the viewpoint.
Color | Yes | Color of the component. This can be used to provide special highlighting of components in the viewpoint. The color is given in ARGB format.


In addition, it has the following information:

Element | Optional | Description |  
:-----------|:------------|:------------
OriginatingSystem | Yes | Name of the system in which the component is originated
AuthoringToolId | Yes | System specific identifier of the component in the originating BIM tool

### OrthogonalCamera (optional)
This element describes a viewpoint using orthogonal camera. It has the following elements:

Element | Optional | Description |  
:-----------|:------------|:------------
CameraViewPoint | No | Camera location
CameraDirection | No | Camera direction
CameraUpVector | No | Camera up vector
ViewToWorldScale | No | Scaling from view to world

### PerspectiveCamera (optional)
This element describes a viewpoint using perspective camera. It has the following 

Element | Optional | Description |  
:-----------|:------------|:------------
CameraViewPoint | No | Camera location
CameraDirection | No | Camera direction
CameraUpVector | No | Camera up vector
FieldOfView | No | Camera’s field of view angle in degrees.

### Lines (optional)
Lines can be used to add markup in 3D. Each line is defined by three dimensional Start Point and End Point.

### ClippingPlanes (optional)
ClippingPlanes can be used to define a subsection of a building model that is related to the topic. Each clipping plane is defined by Location and Direction.

### Bitmap (optional)
Bitmap can be used to add more information, for example, text in the visualization. It has the following elements:


Element | Optional | Description |  
:-----------|:------------|:------------
Bitmap | No | Format of the bitmap (PNG/JPG)
Reference | No | Name of the bitmap file in the topic folder
Location | No | Location of the center of the bitmap in world coordinates
Normal | No | Normal vector of the bitmap
Up | No | Up vector of the bitmap

## Implementation Agreements 
Since BCF 2.0 is compatible with version 1.0, there are some ambiguities in the implementation. The following agreements are written to clarify the implementation.

### One to Many Mapping between Viewpoints and Comments
The schema would allow to have many to many mapping between viewpoints and comments. This is not allowed. A viewpoint can have multiple comments, but a comment can only refer to one viewpoint.

### Status and VerbalStatus to be Phased out
Status and Verbal Status of Comment will be phased out and replaced by TopicStatus and TopicType in Topic. 

When interpreting BCF 1.0 files use the following logic:

- use Status of most recent comment as value of TopicType
- use Verbalstatus of most recent comment as TopicStatus.

When interpreting BCF 2.0 files: VerbalStatus and Status on comment level should all be neglected if TopicStatus and TopicType are present in Topic.

When writing BCF 2.0 files:

- write the current type and status to Topic's TopicType and TopicStatus
- write Status and VerbalStatus at Comment level for backward compatibility.

### Optimizing Viewpoint Size
There can be lots of component references in a viewpoint. Sometimes all components in the model are listed in a viewpoint. This creates huge BCF files. In BCF 2.0 the visibility of components is done with the new Selected and Visible flags, which give new possibilities to optimize and control visibility and reduce viewpoint sizes at the same time. The creating software should for example not list all components in a viewpoint and use clipping planes at the same time to reduce the visibility.

The optimization is done with the following agreements:

- If most of the components are visible, export the invisible components with the visible flag as false.
- If most of the components are invisible, export the visible components with the visible flag as true.
- Do NOT combine in one viewpoint components listed as visible and listed as invisible. This can lead to inconsistent visibility in (changed) IFC files
- If NO components are listed in the viewpoint it means: all components are visible

The visualization is done then with the following logic:
- (Default) If the flag VisibilityBase is not set, or set to Initial:
   - If the viewpoint contains hidden components (visible is false), hide them and show all the rest.
   - If the viewpoint does not contain any hidden components, show only the visible components.
- If the flag VisiblityBase is set to AllVisible
   - Hide the hidden components (visible is false), and show all the rest.
- If the flag VisiblityBase is set to AllInvisible
   - Show the visible components (visible is true), and hide the rest.

### Usage of Selected Flag in Visualization
The Selected flag in Component node in visualization is used as a hint to the visualization to indicate that the component should be selected. When the flag is true, the component is considered visible and the Visible flag does not need to be exported. The Color flag must not be exported, since a color might interfere with the native selection behavior of the visualization software. 

### Usage of Color in Visualization
The Color in Component node in visualization is used specify a custom color for a given component. When the flag is true, the component is considered visible, the values of Visible and Selected flags can be ignored and they don't need to be exported. 

 
