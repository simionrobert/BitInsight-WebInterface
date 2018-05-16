# BitInsight-WebInterface

BitInsight-WebInterface is the front page of [BitInsight](https://github.com/simionrobert/BitInsight.git), an indexer which leverages the DHT protocol 
for crawling infohashes, metadata and IPs.

It is basically a torrent search engine based on elasticsearch database. 
You can also search for IPs to get the torrents they downloaded and geolocation information

It also provides interactive analytics and data statistics about **Bittorrent DHT Network**  

## Elasticsearch database
The website application uses elasticsearch [nest](https://github.com/elastic/elasticsearch-net.git) client to interface with elasticsearch database.

As for the geo locating, the project uses [ingest-geoip plugin](https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest-geoip.html)
which ships by default with the GeoLite2 City, GeoLite2 Country and GeoLite2 ASN geoip2 databases from Maxmind made available under the CCA-ShareAlike 4.0 license. 


The database is composed of 3 indexes: torrent, relation and ip.

### Torrent Index
It contains information mapping about torrent metadata: name, files, size etc.
### Relation Index
It contains the mappings between each torrent the IPs assosiated with it
### IP Index
It contains information about IPs, such as coordinates, country, city name etc.

## Thank You
I really appreciate all kinds of feedback and contributions.

## License
This project is licensed under the MIT License - see the LICENSE.md file for details
