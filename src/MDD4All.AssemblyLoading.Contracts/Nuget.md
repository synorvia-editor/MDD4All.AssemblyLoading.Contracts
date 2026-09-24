One interface, and nothing else.

    Assembly GetAssemblyByPath(string path)

Hand it a path, get an assembly back. How that happens - straight into the current
context, into one of its own that can be dropped again, from a cache - is somebody
else's business, and that is the whole point of keeping it separate.

Targets netstandard2.0.
