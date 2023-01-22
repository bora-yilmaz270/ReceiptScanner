namespace ReceiptScanner.ScannerClient.Model
{
    public class Root
    {
        public string Locale { get; set; }
        public string Description { get; set; }
        public BoundingPoly BoundingPoly { get; set; }
    }
}
