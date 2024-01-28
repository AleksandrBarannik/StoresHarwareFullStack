type Mods = Record<string, boolean | string>

// Helper for combine classes by condition(по условию)
// (analog library  React classNames)
export function classNames(cls: string, mods: Mods = {}, additional: string[] = []): string {
    return [
        cls,
        ...additional.filter(Boolean),
        ...Object.entries(mods)
            .filter(([_, value]) => Boolean(value))
            .map(([className]) => className),

    ]
        .join(' ');
}
