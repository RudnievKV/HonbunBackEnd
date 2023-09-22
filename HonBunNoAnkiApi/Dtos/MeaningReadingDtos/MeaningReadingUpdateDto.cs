﻿namespace HonbunNoAnkiApi.Dtos.MeaningReadingDtos
{
    public record MeaningReadingUpdateDto
    {
        public long? Word_ID { get; init; }

        public string PartOfSpeech { get; init; }
        public string Meaning { get; init; }
        public string Reading { get; init; }
        public string OriginalEntry { get; init; }
    }
}