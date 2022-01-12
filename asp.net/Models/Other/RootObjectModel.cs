namespace asp.net.Models
{
    public class RootObjectModel
    {
        public string Organisasjonsnummer { get; set; }
        public string Navn { get; set; }
        public string Hjemmeside { get; set; }
        public string RegistreringsdatoEnhetsregisteret { get; set; }
        public bool RegistrertIMvaregisteret { get; set; }
        public List<string> FrivilligMvaRegistrertBeskrivelser { get; set; }
        public int AntallAnsatte { get; set; }
        public string Stiftelsesdato { get; set; }
        public bool RegistrertIForetaksregisteret { get; set; }
        public bool RegistrertIStiftelsesregisteret { get; set; }
        public bool RegistrertIFrivillighetsregisteret { get; set; }
        public string SisteInnsendteAarsregnskap { get; set; }
        public bool Konkurs { get; set; }
        public bool UnderAvvikling { get; set; }
        public bool UnderTvangsavviklingEllerTvangsopplosning { get; set; }
        public string Maalform { get; set; }
    }
    
}