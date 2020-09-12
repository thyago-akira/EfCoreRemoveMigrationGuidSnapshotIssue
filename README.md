# EfCoreRemoveMigrationGuidSnapshotIssue

The objective of this repository is to replicate the following Issue:
- https://github.com/dotnet/efcore/issues/19637

To replicate locally the issue:
1. Start a new docker container, with the command "docker-compose up";
2. Remove the last migration;
3. Add a first migration with the Initial Context configuration;
4. Add a second migration without any changes;
5. Remove the last migration;
