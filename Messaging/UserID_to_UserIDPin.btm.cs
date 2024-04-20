namespace Messaging {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Messaging.UserID", typeof(global::Messaging.UserID))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Messaging.UserIDPin", typeof(global::Messaging.UserIDPin))]
    public sealed class UserID_to_UserIDPin : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://Messaging.UserID"" xmlns:ns0=""http://Messaging.UserIDPin"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:UserID"" />
  </xsl:template>
  <xsl:template match=""/s0:UserID"">
    <ns0:UserIDPin>
      <UserIDPinDetail>
        <UID>
          <xsl:value-of select=""UserIDDetail/UID/text()"" />
        </UID>
        <CardID>
          <xsl:value-of select=""UserIDDetail/CardID/text()"" />
        </CardID>
        <xsl:variable name=""var:v1"" select=""userCSharp:GenerateRandomNo()"" />
        <PIN>
          <xsl:value-of select=""$var:v1"" />
        </PIN>
      </UserIDPinDetail>
    </ns0:UserIDPin>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public int GenerateRandomNo()
{
    int _min = 1000;
    int _max = 9999;
    Random _rdm = new Random();
    return _rdm.Next(_min, _max);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Messaging.UserID";
        
        private const global::Messaging.UserID _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Messaging.UserIDPin";
        
        private const global::Messaging.UserIDPin _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Messaging.UserID";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Messaging.UserIDPin";
                return _TrgSchemas;
            }
        }
    }
}
