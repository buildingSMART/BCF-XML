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

## Background
* This document describes the BFC format that is used to exchange topics, such as, issues, scenes, etc. between different BIM software.

## BCF file structure
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



