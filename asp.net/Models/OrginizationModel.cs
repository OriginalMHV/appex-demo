    using System.Text.Json.Serialization;
    namespace asp.net.Models {
    
    public class OrginizationModel
    {
        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Self
    {
        [JsonPropertyName("href")]
        public string Href;
    }

    public class Links
    {
        [JsonPropertyName("self")]
        public Self Self;
    }

    public class Organisasjonsform
    {
        [JsonPropertyName("kode")]
        public string Kode;

        [JsonPropertyName("beskrivelse")]
        public string Beskrivelse;

        [JsonPropertyName("_links")]
        public Links Links;
    }

    public class Naeringskode1
    {
        [JsonPropertyName("beskrivelse")]
        public string Beskrivelse;

        [JsonPropertyName("kode")]
        public string Kode;
    }

    public class Forretningsadresse
    {
        [JsonPropertyName("land")]
        public string Land;

        [JsonPropertyName("landkode")]
        public string Landkode;

        [JsonPropertyName("postnummer")]
        public string Postnummer;

        [JsonPropertyName("poststed")]
        public string Poststed;

        [JsonPropertyName("adresse")]
        public List<string> Adresse;

        [JsonPropertyName("kommune")]
        public string Kommune;

        [JsonPropertyName("kommunenummer")]
        public string Kommunenummer;
    }

    public class InstitusjonellSektorkode
    {
        [JsonPropertyName("kode")]
        public string Kode;

        [JsonPropertyName("beskrivelse")]
        public string Beskrivelse;
    }

    public class Enheter
    {
        [JsonPropertyName("organisasjonsnummer")]
        public string Organisasjonsnummer;

        [JsonPropertyName("navn")]
        public string Navn;

        [JsonPropertyName("organisasjonsform")]
        public Organisasjonsform Organisasjonsform;

        [JsonPropertyName("hjemmeside")]
        public string Hjemmeside;

        [JsonPropertyName("registreringsdatoEnhetsregisteret")]
        public string RegistreringsdatoEnhetsregisteret;

        [JsonPropertyName("registrertIMvaregisteret")]
        public bool RegistrertIMvaregisteret;

        [JsonPropertyName("frivilligMvaRegistrertBeskrivelser")]
        public List<string> FrivilligMvaRegistrertBeskrivelser;

        [JsonPropertyName("naeringskode1")]
        public Naeringskode1 Naeringskode1;

        [JsonPropertyName("antallAnsatte")]
        public int AntallAnsatte;

        [JsonPropertyName("forretningsadresse")]
        public Forretningsadresse Forretningsadresse;

        [JsonPropertyName("stiftelsesdato")]
        public string Stiftelsesdato;

        [JsonPropertyName("institusjonellSektorkode")]
        public InstitusjonellSektorkode InstitusjonellSektorkode;

        [JsonPropertyName("registrertIForetaksregisteret")]
        public bool RegistrertIForetaksregisteret;

        [JsonPropertyName("registrertIStiftelsesregisteret")]
        public bool RegistrertIStiftelsesregisteret;

        [JsonPropertyName("registrertIFrivillighetsregisteret")]
        public bool RegistrertIFrivillighetsregisteret;

        [JsonPropertyName("sisteInnsendteAarsregnskap")]
        public string SisteInnsendteAarsregnskap;

        [JsonPropertyName("konkurs")]
        public bool Konkurs;

        [JsonPropertyName("underAvvikling")]
        public bool UnderAvvikling;

        [JsonPropertyName("underTvangsavviklingEllerTvangsopplosning")]
        public bool UnderTvangsavviklingEllerTvangsopplosning;

        [JsonPropertyName("maalform")]
        public string Maalform;

        [JsonPropertyName("_links")]
        public Links Links;
    }

    public class Embedded
    {
        [JsonPropertyName("enheter")]
        public List<Enheter> Enheter;
    }

    public class Page
    {
        [JsonPropertyName("size")]
        public int Size;

        [JsonPropertyName("totalElements")]
        public int TotalElements;

        [JsonPropertyName("totalPages")]
        public int TotalPages;

        [JsonPropertyName("number")]
        public int Number;
    }

    public class Root
    {
        [JsonPropertyName("_embedded")]
        public Embedded Embedded;

        [JsonPropertyName("_links")]
        public Links Links;

        [JsonPropertyName("page")]
        public Page Page;
    }
}
}

