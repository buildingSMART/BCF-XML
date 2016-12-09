##BCF XML - Change Log

Draft version 2.1 / 1.August2016
==================

project.xsd
  * Added new element "Project/Name". Name of the project.


markup.xsd
  * Modified element "Topic/ReferenceLink" to be a list of reference links.	

  * Added element "Topic/DueDate". Date until when the topics issue needs to be resolved.

  * Renamed element "Topic/RelatedTopics" to "Topic/RelatedTopic".

  * Removed element "Comment/VerbalStatus". In V2.1 the status of a topic is represented only by the attrbute "Topic/TopicStatus".

  * Removed element "Comment/Status". In V2.1 the status of a topic is represented only by the attrbute "Topic/TopicStatus".

  * Removed element "Comment/Topic/GUID". Backreference to the topic is not needed.

  * Removed element "Comment/ReplyToComment".

  * Added element "Viewpoints/Index". Parameter for sorting.

visinfo.xsd
  * Added attribute "Components/DefaultVisibility" that indicates true or false for all components of this viewpoint.	

  * Added component list elements "Spaces".

  * Added component list elements "SpaceBounderies".

  * Added component list elements "Openings".

  * Modify element "Bitmap" to be a list.


Version 2.0 / 1.October2014
==================

project.xsd
  * New schema.

version.xsd
  * New schema.

extension.xsd
  * New schema.


markup.xsd
  * Added new attribute "isExternal" and new element "Reference" to "Header/File".

  * Added new attributes "TopicType" and "TopicStatus" to "Topic". The type and the status of a topic (value from extension.xsd).

  * Added new element "Priority" to "Topic". The priority of a topic (value from extension.xsd).

  * Added new element "Index" to "Topic". The index of a topic.

  * Added new list "Labels" to "Topic". The collection of labels of a topic (values from extension.xsd).

  * Added new element "CreationDate" to "Topic".

  * Added new element "CreationAuthor" to "Topic". UserID (values from extension.xsd).

  * Added new element "ModifiedDate" to "Topic".

  * Added new element "ModifiedAuthor" to "Topic". UserID (values from extension.xsd).

  * Added new element "AssignedTo" to "Topic". UserID (values from extension.xsd).

  * Added new elements for a "BIM-Snippet" to "Topic". Values for the "SnippetType" from extension.xsd.

  * Added new elements for a list of "DocumentReferences" to "Topic".

  * Added new elements for a list of "RelatedTopics" to "Topic".

  * Added new attribute "Viewpoint/GUID" to "Comment".

  * Added new element "ModifiedDate" to "Comment".

  * Added new element "ModifiedAuthor" to "Comment". Values can be predefined in the extension.xsd.

  * Added new elements for a list of "Viewpoints" to the "Markup".


Version 1.0 / 6.April2010
==================

  * Initial commit