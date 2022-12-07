Questa libreria definisce la classe publica XmlSerializerTCP in grado di serializzare e deserializzare su un flusso TCP
evitando i problemi relativi alla normale deserializzazione su NetworkStream ( la deserializer entra in loop infinito attendendo la EOS ) 

La libreria implementa due classi private ( per uso interno alla libreria ) che vanno a sovrascrivere delle funzionalità base di:
- XmlReaderTcp estende ( in realtà wrappa ) XmlReader andando a settare i settings corretti nel costruttore ed wrappando il NetworksStream nello StreamWrap
- StreamWrap che estende ( in realtà wrappa ) uno Stream generico e che permette di limitare il numero di byte letti in fase di lettura ( 1 alla volta in questo caso)



La libreria NON è ottimizzata al 100%
per una normale comunicazione va più che bene (qualche pacchetto, anche pesante, al secondo è considerato normale ), 
in caso di scambio di dati real-time occorre fare un ottimizzazione ( e magari non usare XML ... )