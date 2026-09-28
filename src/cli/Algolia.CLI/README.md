# Algolia.CLI

Command-line interface for the Algolia SDK generated with AutoSDK.

## Installation

```bash
dotnet tool install --global Algolia.CLI --prerelease
```

## Usage

```bash
algolia --help
algolia api --help
```

## Customization

Generated operation, tag, and API group command classes are partial. Implement
`static partial void CustomizeCommand(ref Command command)` in a separate source
file to add aliases or validators, change the action, or replace a command. The
hook runs after the generated command has been configured.