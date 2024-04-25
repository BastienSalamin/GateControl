namespace Messaging {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Messaging.PinControl", typeof(global::Messaging.PinControl))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Messaging.UserIDPin", typeof(global::Messaging.UserIDPin))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Messaging.PinAnswer", typeof(global::Messaging.PinAnswer))]
    public sealed class Transform_PinComparaison : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s2 s0 s1 userCSharp"" version=""1.0"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s0=""http://Messaging.PinControl"" xmlns:ns0=""http://Messaging.PinAnswer"" xmlns:s1=""http://Messaging.UserIDPin"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <ns0:PinAnswer>
      <PinAnswerDetail>
        <UID>
          <xsl:value-of select=""InputMessagePart_0/s0:PinControl/PinControlDetail/UID/text()"" />
        </UID>
        <xsl:variable name=""var:v1"" select=""userCSharp:PinComparaison(string(InputMessagePart_1/s1:UserIDPin/UserIDPinDetail/PIN/text()) , string(InputMessagePart_0/s0:PinControl/PinControlDetail/PIN/text()))"" />
        <Answer>
          <xsl:value-of select=""$var:v1"" />
        </Answer>
      </PinAnswerDetail>
    </ns0:PinAnswer>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool PinComparaison(int param1, int param2)
{
	return param1 == param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Messaging.PinControl";
        
        private const global::Messaging.PinControl _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"Messaging.UserIDPin";
        
        private const global::Messaging.UserIDPin _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"Messaging.PinAnswer";
        
        private const global::Messaging.PinAnswer _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"Messaging.PinControl";
                _SrcSchemas[1] = @"Messaging.UserIDPin";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Messaging.PinAnswer";
                return _TrgSchemas;
            }
        }
    }
}
