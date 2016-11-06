<Query Kind="Expression" />

///						+---------------+
///						|     Crawl     |
///						+---------------+
///							/		 \
///						   /		  \
///						  /			   \
///		+---------------+				+---------------+
///		|  SimpleParse  |				|   SaveToDrive |
///		+---------------+				+---------------+
///				|	     \
///				|		   ------------
///				|		   			   \
///		+---------------+  				+---------------+
///		|   Recognise   |   			|   GetImages   |
///		+---------------+   			+---------------+
///				|								|
///				|								|
///				|								|
///		+---------------+				+---------------+
///		|  SaveToDrive  |				|    Rescale    |
///		+---------------+				+---------------+
///				|								|
///				|								|
///				|								|
///				|						+---------------+
///				|						|  SaveToDrive  |
///				|						+---------------+
///				|					   /		
///				|		   ------------			
///				|		 /						
///		+---------------+				
///		|     Combine   |				
///		+---------------+			
///				|
///				|
///				|
///		+---------------+  				+---------------+
///		|  CreateDbRep  | ----------->	|  SaveToFile   |
///		+---------------+				+---------------+
///				|	     
///				|		 
///				|		 
///		+----------------+
///		| SaveToDatabase |
///		+----------------+