// @ts-nocheck
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type Scalars = {
    String: string,
    Boolean: boolean,
}

export interface Author {
    name: Scalars['String']
    __typename: 'Author'
}

export interface Book {
    title: Scalars['String']
    author: Author
    __typename: 'Book'
}

export interface Mutation {
    addBook: Book
    __typename: 'Mutation'
}

export interface Query {
    book: Book
    __typename: 'Query'
}

export interface SubscriptionType {
    bookAdded: (Book | null)
    __typename: 'SubscriptionType'
}

export type Subscription = SubscriptionType

export interface AuthorGenqlSelection{
    name?: boolean | number
    __typename?: boolean | number
    __scalar?: boolean | number
}

export interface BookGenqlSelection{
    title?: boolean | number
    author?: AuthorGenqlSelection
    __typename?: boolean | number
    __scalar?: boolean | number
}

export interface MutationGenqlSelection{
    addBook?: (BookGenqlSelection & { __args: {book: BookInput} })
    __typename?: boolean | number
    __scalar?: boolean | number
}

export interface QueryGenqlSelection{
    book?: BookGenqlSelection
    __typename?: boolean | number
    __scalar?: boolean | number
}

export interface SubscriptionTypeGenqlSelection{
    bookAdded?: BookGenqlSelection
    __typename?: boolean | number
    __scalar?: boolean | number
}

export interface AuthorInput {name: Scalars['String']}

export interface BookInput {title: Scalars['String'],author: AuthorInput}

export type SubscriptionGenqlSelection = SubscriptionTypeGenqlSelection


    const Author_possibleTypes: string[] = ['Author']
    export const isAuthor = (obj?: { __typename?: any } | null): obj is Author => {
      if (!obj?.__typename) throw new Error('__typename is missing in "isAuthor"')
      return Author_possibleTypes.includes(obj.__typename)
    }
    


    const Book_possibleTypes: string[] = ['Book']
    export const isBook = (obj?: { __typename?: any } | null): obj is Book => {
      if (!obj?.__typename) throw new Error('__typename is missing in "isBook"')
      return Book_possibleTypes.includes(obj.__typename)
    }
    


    const Mutation_possibleTypes: string[] = ['Mutation']
    export const isMutation = (obj?: { __typename?: any } | null): obj is Mutation => {
      if (!obj?.__typename) throw new Error('__typename is missing in "isMutation"')
      return Mutation_possibleTypes.includes(obj.__typename)
    }
    


    const Query_possibleTypes: string[] = ['Query']
    export const isQuery = (obj?: { __typename?: any } | null): obj is Query => {
      if (!obj?.__typename) throw new Error('__typename is missing in "isQuery"')
      return Query_possibleTypes.includes(obj.__typename)
    }
    


    const SubscriptionType_possibleTypes: string[] = ['SubscriptionType']
    export const isSubscriptionType = (obj?: { __typename?: any } | null): obj is SubscriptionType => {
      if (!obj?.__typename) throw new Error('__typename is missing in "isSubscriptionType"')
      return SubscriptionType_possibleTypes.includes(obj.__typename)
    }
    