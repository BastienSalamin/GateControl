namespace Messaging {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Messaging.DemandeHeure", typeof(global::Messaging.DemandeHeure))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Messaging.WorkTime", typeof(global::Messaging.WorkTime))]
    public sealed class DemandeHeure_to_WorkTime : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0"" version=""1.0"" xmlns:s0=""http://Messaging.DemandeHeure"" xmlns:ns0=""http://Messaging.WorkTime"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:DemandeHeure"" />
  </xsl:template>
  <xsl:template match=""/s0:DemandeHeure"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringUpperCase(string(UID/text()))"" />
    <xsl:variable name=""var:v4"" select=""string(UID/text())"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringUpperCase($var:v4)"" />
    <ns0:WorkTime>
      <WorkTimeDetail>
        <UID>
          <xsl:value-of select=""UID/text()"" />
        </UID>
        <xsl:variable name=""var:v2"" select=""ScriptNS0:DBLookup(0 , string($var:v1) , &quot;Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False; Initial Catalog=AdvWorks;Data Source=(local)&quot; , &quot;WorkTime&quot; , &quot;UID&quot;)"" />
        <xsl:variable name=""var:v3"" select=""ScriptNS0:DBValueExtract(string($var:v2) , &quot;Date&quot;)"" />
        <Date>
          <xsl:value-of select=""$var:v3"" />
        </Date>
        <xsl:variable name=""var:v6"" select=""ScriptNS0:DBLookup(0 , string($var:v5) , &quot;Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False; Initial Catalog=AdvWorks;Data Source=(local)&quot; , &quot;WorkTime&quot; , &quot;UID&quot;)"" />
        <xsl:variable name=""var:v7"" select=""ScriptNS0:DBValueExtract(string($var:v6) , &quot;StartHour&quot;)"" />
        <StartHour>
          <xsl:value-of select=""$var:v7"" />
        </StartHour>
        <xsl:variable name=""var:v8"" select=""ScriptNS0:DBLookup(0 , string($var:v5) , &quot;Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False; Initial Catalog=AdvWorks;Data Source=(local)&quot; , &quot;WorkTime&quot; , &quot;UID&quot;)"" />
        <xsl:variable name=""var:v9"" select=""ScriptNS0:DBValueExtract(string($var:v8) , &quot;EndHour&quot;)"" />
        <EndHour>
          <xsl:value-of select=""$var:v9"" />
        </EndHour>
        <xsl:variable name=""var:v10"" select=""ScriptNS0:DBLookup(0 , string($var:v5) , &quot;Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False; Initial Catalog=AdvWorks;Data Source=(local)&quot; , &quot;WorkTime&quot; , &quot;UID&quot;)"" />
        <xsl:variable name=""var:v11"" select=""ScriptNS0:DBValueExtract(string($var:v10) , &quot;Salle&quot;)"" />
        <DefaultAccessRights>
          <xsl:value-of select=""$var:v11"" />
        </DefaultAccessRights>
      </WorkTimeDetail>
    </ns0:WorkTime>
    <xsl:variable name=""var:v12"" select=""ScriptNS0:DBLookupShutdown()"" />
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""Microsoft.BizTalk.BaseFunctoids, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" ClassName=""Microsoft.BizTalk.BaseFunctoids.FunctoidScripts"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"Messaging.DemandeHeure";
        
        private const global::Messaging.DemandeHeure _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Messaging.WorkTime";
        
        private const global::Messaging.WorkTime _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Messaging.DemandeHeure";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Messaging.WorkTime";
                return _TrgSchemas;
            }
        }
    }
}
