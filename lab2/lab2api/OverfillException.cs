namespace lab2api;

class OverfillException : Exception {
    public OverfillException(string message) : base(message) {
    }
}