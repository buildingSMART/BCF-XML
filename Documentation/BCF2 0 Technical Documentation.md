# BIM Collaboration Format v2.0 Technical Documentation

Authors:

* Pasi Paasiala, Solibri (BCF 1.0 / BCF 2.0)
* Juha Laukala, Tekla (BCF 1.0)
* Lassi Lifländer, Tekla (BCF 1.0)
* Klaus Linhard, IABI (BCF 2.0)

## Terms and Abbreviations



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
* This document describes the BFC format that is used to exchange topics, such as, issues, scenes, etc. between different BIM software.

### BCF file structure
In the root of the BCF file is an XML file defining project related information. The name of this file is project.xml. This file follows the project.xsd schema.

A BCF file is a zip containing one folder for each topic. The folder name is the GUID of the topic. This GUID is in the UUID form. The folder contains the following files:

* project.bcfp (optional)
    - An XML file referencing the extension.xsd to a project.
* markup.bcf
    * An XML file following the markup.xsd schema that is described below.
* viewpoint.bcfv
    * An XML file following the visinfo.xsd schema that is described below (for compatibility with BCF 1.0).
    * Multiple viewpoints are possible in BCF 2.0. Names of these files are not predefined.
* snapshot.png 
    *  A snapshot related to the topic (for compatibility with BCF 1.0).
Multiple snapshots are possible in BCF 2.0. Names of these files are not predefined.


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
ReferenceLink | Yes | Reference to the topic in, for example, a work request management system.
Title | No | Title of the topic.
Index | Yes | Number to maintain the order of the topics.

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

### AssignedTo (optional)
A topic can be assigned to a person.

Element | Optional | Description |  
:-----------|:------------|:------------
AssignedToEmail | Yes | The email-address of the person the topic is assigned to
AssignedToName | Yes | The name of the person the topic is assigned to


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
AuthorEmail | No | Email address of the comment author.
Priority | Yes | Priority of the comment (Predefined list in “extension.xsd”)


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
Color | Yes | Color of the component. This can be used to provide special highlighting of components in the viewpoint.


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







