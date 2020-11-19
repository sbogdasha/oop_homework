<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:output
    method ="html"></xsl:output>
  <xsl:template match="/">
    <html>
      <body>
        <table border ="1">
          <TR>
            <th>Brand</th>
            <th>Type</th>
            <th>Fabric</th>
            <th>Color</th>
            <th>Season</th>
          </TR>
          <xsl:for-each select="Clothing/Wardrobe">
            <tr>
              <td>
                <xsl:value-of select ="@Brand"/>
              </td>
              <td>
                <xsl:value-of select ="@Type"/>
              </td>
              <td>
                <xsl:value-of select ="@Fabric"/>
              </td>
              <td>
                <xsl:value-of select ="@Color"/>
              </td>
              <td>
                <xsl:value-of select ="@Season"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
