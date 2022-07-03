#include <stdio.h>
#include <stdlib.h>

int main()
{
    // Basic C madlibs game
    char color[20];
    char pluralNoun[20];
    char celebrityFirst[20];
    char celebrityLast[20];

    printf("Enter a color: ");
    scanf("%s", color);
    printf("Enter a plural noun: ");
    scanf("%s", pluralNoun);
    printf("Enter a celebrity: ");
    scanf("%s%s", celebrityFirst, celebrityLast);

    if(strlen(celebrityFirst) < 1 || strlen(celebrityLast) < 1) {
        printf("You should enter the person's full name, unless it's Prince.");
    }

    printf("Roses are %s\n", color);
    printf("%s are blue\n", pluralNoun);
    printf("I love %s %s\n", celebrityFirst, celebrityLast);

    return 0;
}
