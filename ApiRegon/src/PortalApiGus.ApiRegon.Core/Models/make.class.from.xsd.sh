#!/bin/bash

PATH=$PATH:"/C/Program Files (x86)/Microsoft SDKs/Windows/v10.0A/bin/NETFX 4.8 Tools"

xsd.exe .\DanePobierzPelnyRaport\BIR11OsPrawna.xsd /c /language:CS /namespace:PortalApiGus.ApiRegon.Core.Models.DanePobierzPelnyRaport /type:OsPrawna /nologo /outputdir:D:\Praca\NetCoreDev\PortalApiGus\ApiRegon\src\PortalApiGus.ApiRegon.Core\Models\DanePobierzPelnyRaport\

#Microsoft (R) Xml Schemas/DataTypes support utility
#[Microsoft (R) .NET Framework, Version 4.8.3928.0]
#Copyright (C) Microsoft Corporation. All rights reserved.
#xsd.exe -
#    Utility to generate schema or class files from given source.
#xsd.exe <schema>.xsd /classes|dataset [/e:] [/l:] [/n:] [/o:] [/s] [/uri:]
#xsd.exe <assembly>.dll|.exe [/outputdir:] [/type: [...]]
#xsd.exe <instance>.xml [/outputdir:]
#xsd.exe <schema>.xdr [/outputdir:]
#     - OPTIONS -
#/classes
#    Generate classes for this schema. Short form is '/c'.
#/dataset
#    Generate sub-classed DataSet for this schema. Short form is '/d'.
#/enableLinqDataSet
#    Generate LINQ-enabled sub-classed Dataset for the schemas provided.  Short form is '/eld'.
#/element:<element>
#    Element from schema to process. Short form is '/e:'.
#/fields
#    Generate fields instead of properties. Short form is '/f'.
#/order
#    Generate explicit order identifiers on all particle members.
#/enableDataBinding
#    Implement INotifyPropertyChanged interface on all generated types
#    to enable data binding. Short form is '/edb'.
#/language:<language>
#    The language to use for the generated code. Choose from 'CS', 'VB', 'JS',
#    'VJS', 'CPP' or provide a fully-qualified name for a class implementing
#    System.CodeDom.Compiler.CodeDomProvider. The default language
#    is 'CS' (CSharp). Short form is '/l:'.
#/namespace:<namespace>
#    The namespace for generated class files. The default namespace
#    is the global namespace. Short form is '/n:'.
#/nologo
#    Suppresses the banner.
#/out:<directoryName>
#    The output directory to create files in. The default
#    is the current directory. Short form is '/o:'.
#/type:<type>
#   Type from assembly to generate schema for. Multiple types may be provided.
#   If no types are provided, then schemas for all types in an assembly
#   are generated. Short form is '/t:'.
#/uri:<uri>
#    Uri of elements from schema to process. Short form is '/u:'.
#     - ADVANCED -
#/parameters:<file>
#    Read command-line options from the specified xml file. Short form is '/p:'.
#     - ARGUMENTS -
#<schema>.xsd       Name of a schema containing elements to import.
#<assembly>.dll|exe Name of an assembly containing types to generate schema for.
#<instance>.xml     Name of an xml file to infer xsd schema from.
#<schema>.xdr       Name of an xdr schema to convert to xsd.
#Multiple file arguments of the same type may be provided.