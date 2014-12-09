db-lookup-extensions
===============

A reusable component that maps lookup values in databases to .NET Enums using EntityFramework and a Fluent API with clean code that uses declarative attributes.

Eg. var standardReceipt = _service.From<ReceiptType>().Get(ReceiptTypes.StandardReceipt);
