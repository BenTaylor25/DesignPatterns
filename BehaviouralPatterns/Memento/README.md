# Memento

The Memento Pattern is used to
externalise an object's internal
state to enable restoration, but
without breaking the rules of
encapsulation.

Memento is commonly used for
applications with an undo feature.

Specifically, a Memento is used
as a snapshot of the current
object state.

```cs
class TextArea
{
    private string? text;

    public void SetText(string text)
    {
        this.text = text;
    }

    public Memento TakeSnapshot()
    {
        return new Memento(this.text);
    }

    public void Restore(Memento memento)
    {
        this.text = memento.GetSavedText();
    }

    public static class Memento
    {
        private sealed string text;

        private Memento(string _text)
        {
            text = _text;
        }

        private string GetSavedText()
        {
            return text;
        }
    }
}

class Editor
{
    private List<Memento> stateHistory;
    private TextArea textArea;

    public Editor()
    {
        stateHistory = new();
        textArea = new();
    }

    public void Write(string text)
    {
        textArea.set(text);
        stateHistory.Add(textArea.takeSnapshot());
    }

    public void Undo()
    {
        textArea.Restore(stateHistory.Last());
        stateHistory.RemoveAt(stateHistory.Count - 1);
    }
}
```
