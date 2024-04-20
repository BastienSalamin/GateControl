namespace Messaging {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Messaging.StartBadgeMaker", typeof(global::Messaging.StartBadgeMaker))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Messaging.Access", typeof(global::Messaging.Access))]
    public sealed class StartBadgeMaker_to_Access : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://Messaging.StartBadgeMaker"" xmlns:ns0=""http://Messaging.Access"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:ConvertHex(string(StartFile/CardID/text()))"" />
    <ns0:Access>
      <AccessDetail>
        <xsl:attribute name=""CardID"">
          <xsl:value-of select=""$var:v1"" />
        </xsl:attribute>
        <DefaultAccessRights>
          <xsl:value-of select=""StartFile/DefaultAccessRights/text()"" />
        </DefaultAccessRights>
      </AccessDetail>
    </ns0:Access>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string ConvertHex(string val)
{
	string retval = """";
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		int v = (int) d;
		retval = Convert.ToString(v, 16).ToUpper(System.Globalization.CultureInfo.InvariantCulture);
	}
	return retval;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Messaging.StartBadgeMaker";
        
        private const global::Messaging.StartBadgeMaker _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Messaging.Access";
        
        private const global::Messaging.Access _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Messaging.StartBadgeMaker";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Messaging.Access";
                return _TrgSchemas;
            }
        }
    }
}
