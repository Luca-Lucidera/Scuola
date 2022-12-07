/**
 *
 * @author lucid
 */
public class Place {
    private String amenity,road, town, county, state, country_code;
    private int postcode;

    public Place() {
    }

     
    public Place(String amenity, String road, String town, String county, String state, String country_code, int postcode) {
        this.amenity = amenity;
        this.road = road;
        this.town = town;
        this.county = county;
        this.state = state;
        this.country_code = country_code;
        this.postcode = postcode;
    }

    public void setAmenity(String amenity) {
        this.amenity = amenity;
    }

    public void setRoad(String road) {
        this.road = road;
    }

    public void setTown(String town) {
        this.town = town;
    }

    public void setCounty(String county) {
        this.county = county;
    }

    public void setState(String state) {
        this.state = state;
    }

    public void setCountry_code(String country_code) {
        this.country_code = country_code;
    }

    public void setPostcode(int postcode) {
        this.postcode = postcode;
    }

    public String getAmenity() {
        return amenity;
    }

    public String getRoad() {
        return road;
    }

    public String getTown() {
        return town;
    }

    public String getCounty() {
        return county;
    }

    public String getState() {
        return state;
    }

    public String getCountry_code() {
        return country_code;
    }

    public int getPostcode() {
        return postcode;
    }
    
}
