# OOPs-Master-Solution

A learning repository demonstrating SOLID principles and clean object-oriented design using C# and .NET 8. The solution contains small, focused projects that illustrate the Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, and Dependency Inversion principles.

## Repository Structure

- `OOP.Domain/` - Domain examples organized by SOLID principle. Each folder contains small classes and example implementations (good and bad) to illustrate the principle.
  - `SOLID/SRP/` - Single Responsibility Principle examples (e.g., `InvoiceCreate.cs`, `InvoicePrint.cs`, `BadExample.cs`).
  - `SOLID/OCP/` - Open/Closed Principle examples (e.g., `IPaymentGateway.cs`, `RazorPayGateway.cs`, `BadExample.cs`).
  - `SOLID/LSP/` - Liskov Substitution Principle examples (e.g., `IDiscount.cs`, `FixedDiscount.cs`, `NoDiscount.cs`, `BadExample.cs`).
  - `SOLID/ISP/` - Interface Segregation Principle examples (e.g., `IPayment.cs`, `IRefund.cs`, `IStatus.cs`, `EaseBuzzGateway.cs`, `BadExample.cs`).
  - `SOLID/DIP/` - Dependency Inversion Principle examples (e.g., `IDIPPaymentGateway.cs`, `HDFCSmartGateway.cs`).

- `OOP.WebAPI/` - Minimal Web API project exposing controllers to demonstrate usage of the domain examples.
  - `Controllers/SOLIDController.cs` - Example endpoints used to exercise SOLID examples.
  - `Program.cs` - App bootstrapping and DI configuration.

## Requirements

- .NET SDK 8.0
- Visual Studio 2022 or VS Code (or any editor that supports .NET 8)

## Getting Started

1. Clone the repository:

    ```bash
    git clone https://github.com/anurag-pw/OOPs-Solution.git
    cd OOPs-Master-Solution
    ```

2. Build the solution:

    ```bash
    dotnet build
    ```

3. Run the Web API:

    ```bash
    cd OOP.WebAPI
    dotnet run
    ```

   By default, the API will bind to the URLs shown in the console (e.g., `http://localhost:5000` / `https://localhost:5001`).

## Usage / Endpoints

This repository contains a `SOLIDController` which exposes endpoints that demonstrate the domain examples. Example usage (adjust host/port as needed):

- GET `/api/solid/srp` - Demonstrates Single Responsibility Principle examples.
- GET `/api/solid/ocp` - Demonstrates Open/Closed Principle usage with payment gateway abstractions.
- GET `/api/solid/lsp` - Demonstrates Liskov Substitution Principle examples.
- GET `/api/solid/isp` - Demonstrates Interface Segregation Principle examples.
- GET `/api/solid/dip` - Demonstrates Dependency Inversion Principle examples.

Use curl or a browser to call endpoints:

```bash
curl http://localhost:5000/api/solid/srp
```

Adjust the route and port to the running application.

## Testing and Examples

- The repository currently contains example classes and controllers for manual experimentation. Add unit tests by creating a `tests/` project and referencing the domain classes to assert behavior.

## Coding Standards

This project follows repository-level coding and formatting conventions. An `.editorconfig` and `CONTRIBUTING.md` will be included to enforce consistent style and contribution practices. Please follow those files when submitting changes.

## Contributing

Contributions are welcome. Open an issue to discuss proposed changes or submit a pull request. Keep changes focused and follow the coding standards in `.editorconfig` and the guidelines in `CONTRIBUTING.md`.

## License

This repository does not include a license file. If you plan to publish or share this project, add a `LICENSE` file describing the terms.

---

If you want, I can create the `README.md`, `.editorconfig`, and `CONTRIBUTING.md` files and open a branch/PR with the changes. Let me know which headings or additional details to include or any preferred license.