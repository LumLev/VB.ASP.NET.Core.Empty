<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
				
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>

	<xsl:template match="/WeatherForecast" name="WeatherForecast">
		<div style="border: 3px solid black; padding: 1rem 1rem;">
			<h4>
				Today is <xsl:value-of select="/WeatherForecast/TheDate"/>
				and the weather is <xsl:value-of select="/WeatherForecast/Summary"/>
			</h4>
			<h4> 
				Celsius: <xsl:value-of select="/WeatherForecast/TemperatureC"/>
			</h4>
			<h4 style="color: lightgrey;">
				Fahrenheit: <xsl:value-of select="/WeatherForecast/TemperatureF"/>
			</h4>
			<button onclick="doSmthNew()"> New Random Weather Data </button>
		</div>
	</xsl:template>
	
</xsl:stylesheet>
