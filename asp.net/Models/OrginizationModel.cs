    using System.Text.Json.Serialization;
    namespace asp.net.Models {
    
    public class OrginizationModel
    {
        public class Self
    {
        public string Href { get; set; }
    }

    public class Links
    {
        public Self Self { get; set; }
    }

    public class Organisasjonsform
    {
        public string Kode { get; set; }
        public string Beskrivelse { get; set; }
        public Links Links { get; set; }
    }

    public class Naeringskode1
    {
        public string Beskrivelse { get; set; }
        public string Kode { get; set; }
    }

    public class Forretningsadresse
    {
        public string Land { get; set; }
        public string Landkode { get; set; }
        public string Postnummer { get; set; }
        public string Poststed { get; set; }
        public List<string> Adresse { get; set; }
        public string Kommune { get; set; }
        public string Kommunenummer { get; set; }
    }

    public class InstitusjonellSektorkode
    {
        public string Kode { get; set; }
        public string Beskrivelse { get; set; }
    }

    public class Enheter
    {
        public string Organisasjonsnummer { get; set; }
        public string Navn { get; set; }
        public Organisasjonsform Organisasjonsform { get; set; }
        public string Hjemmeside { get; set; }
        public string RegistreringsdatoEnhetsregisteret { get; set; }
        public bool RegistrertIMvaregisteret { get; set; }
        public List<string> FrivilligMvaRegistrertBeskrivelser { get; set; }
        public Naeringskode1 Naeringskode1 { get; set; }
        public int AntallAnsatte { get; set; }
        public Forretningsadresse Forretningsadresse { get; set; }
        public string Stiftelsesdato { get; set; }
        public InstitusjonellSektorkode InstitusjonellSektorkode { get; set; }
        public bool RegistrertIForetaksregisteret { get; set; }
        public bool RegistrertIStiftelsesregisteret { get; set; }
        public bool RegistrertIFrivillighetsregisteret { get; set; }
        public string SisteInnsendteAarsregnskap { get; set; }
        public bool Konkurs { get; set; }
        public bool UnderAvvikling { get; set; }
        public bool UnderTvangsavviklingEllerTvangsopplosning { get; set; }
        public string Maalform { get; set; }
        public Links Links { get; set; }
    }

    public class Embedded
    {
        public List<Enheter> Enheter { get; set; }
    }

    public class Page
    {
        public int Size { get; set; }
        public int TotalElements { get; set; }
        public int TotalPages { get; set; }
        public int Number { get; set; }
    }

    public class Root
    {
        public Embedded Embedded { get; set; }
        public Links Links { get; set; }
        public Page Page { get; set; }
    }

}
}

