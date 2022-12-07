
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import org.w3c.dom.Document;
import org.w3c.dom.Element; 
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;

public class XMLParser {
    private Document document;

    public Document getDocument() {
        return document;
    }
    
    public List ParseDOC(String path)
            throws ParserConfigurationException, SAXException, IOException {
        DocumentBuilderFactory factory;
        DocumentBuilder builder;
        Element root, element;
        NodeList nodelist;
        
        // creazione dell’albero DOM dal documento XML
        factory = DocumentBuilderFactory.newInstance();
        builder = factory.newDocumentBuilder();
        document = builder.parse(path);
        root = document.getDocumentElement();
        List<Place> dati = new ArrayList();
        Place dato = new Place();
        nodelist = root.getElementsByTagName("place");
        if (nodelist != null && nodelist.getLength() > 0) {
            element = (Element) nodelist.item(1);
            System.out.println(element.getTextContent());
            //element = (Element) nodelist.item(0);
            //System.out.println(element);
//            dato.setAmenity(element.);
//            dato.setRoad(element.getAttribute("road"));
//            dato.setTown(element.getAttribute("town"));
//            dato.setCounty(element.getAttribute("country"));
//            dato.setCountry_code(element.getAttribute("country_code"));
//            System.out.println(dato);
        }
        return dati;
    }
}
