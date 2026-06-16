#nullable enable

using System.CommandLine;

namespace Algolia.CLI.Commands;

internal static class SearchApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"search", @"search endpoint commands.");
                         command.Subcommands.Add(SearchAccountCopyIndexCommandApiCommand.Create());
                         command.Subcommands.Add(SearchAddApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(SearchAddOrUpdateObjectCommandApiCommand.Create());
                         command.Subcommands.Add(SearchAppendSourceCommandApiCommand.Create());
                         command.Subcommands.Add(SearchBatchCommandApiCommand.Create());
                         command.Subcommands.Add(SearchBatchDictionaryEntriesCommandApiCommand.Create());
                         command.Subcommands.Add(SearchBrowseCommandApiCommand.Create());
                         command.Subcommands.Add(SearchBrowseObjectsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchChunkedBatchCommandApiCommand.Create());
                         command.Subcommands.Add(SearchClearObjectsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchClearRulesCommandApiCommand.Create());
                         command.Subcommands.Add(SearchClearSynonymsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchCustomDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(SearchCustomGetCommandApiCommand.Create());
                         command.Subcommands.Add(SearchCustomPostCommandApiCommand.Create());
                         command.Subcommands.Add(SearchCustomPutCommandApiCommand.Create());
                         command.Subcommands.Add(SearchDeleteApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(SearchDeleteByCommandApiCommand.Create());
                         command.Subcommands.Add(SearchDeleteIndexCommandApiCommand.Create());
                         command.Subcommands.Add(SearchDeleteObjectCommandApiCommand.Create());
                         command.Subcommands.Add(SearchDeleteObjectsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchDeleteRuleCommandApiCommand.Create());
                         command.Subcommands.Add(SearchDeleteSourceCommandApiCommand.Create());
                         command.Subcommands.Add(SearchDeleteSynonymCommandApiCommand.Create());
                         command.Subcommands.Add(SearchGenerateSecuredApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(SearchGetApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(SearchGetAppTaskCommandApiCommand.Create());
                         command.Subcommands.Add(SearchGetDictionaryLanguagesCommandApiCommand.Create());
                         command.Subcommands.Add(SearchGetDictionarySettingsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchGetLogsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchGetObjectCommandApiCommand.Create());
                         command.Subcommands.Add(SearchGetObjectsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchGetRuleCommandApiCommand.Create());
                         command.Subcommands.Add(SearchGetSettingsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchGetSourcesCommandApiCommand.Create());
                         command.Subcommands.Add(SearchGetSynonymCommandApiCommand.Create());
                         command.Subcommands.Add(SearchGetTaskCommandApiCommand.Create());
                         command.Subcommands.Add(SearchIndexExistsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchListApiKeysCommandApiCommand.Create());
                         command.Subcommands.Add(SearchListIndicesCommandApiCommand.Create());
                         command.Subcommands.Add(SearchMultipleBatchCommandApiCommand.Create());
                         command.Subcommands.Add(SearchOperationIndexCommandApiCommand.Create());
                         command.Subcommands.Add(SearchPartialUpdateObjectCommandApiCommand.Create());
                         command.Subcommands.Add(SearchPartialUpdateObjectsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchPartialUpdateObjectsWithTransformationCommandApiCommand.Create());
                         command.Subcommands.Add(SearchReplaceAllObjectsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchReplaceAllObjectsWithTransformationCommandApiCommand.Create());
                         command.Subcommands.Add(SearchReplaceSourcesCommandApiCommand.Create());
                         command.Subcommands.Add(SearchRestoreApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSaveObjectCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSaveObjectsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSaveObjectsWithTransformationCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSaveRuleCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSaveRulesCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSaveSynonymCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSaveSynonymsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSearchCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSearchDictionaryEntriesCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSearchForFacetValuesCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSearchRulesCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSearchSingleIndexCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSearchSynonymsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSetClientApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSetDictionarySettingsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchSetSettingsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchUpdateApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(SearchWaitForApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(SearchWaitForAppTaskCommandApiCommand.Create());
                         command.Subcommands.Add(SearchWaitForTaskCommandApiCommand.Create());
        return command;
    }
}