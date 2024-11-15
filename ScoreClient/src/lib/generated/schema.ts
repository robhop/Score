// @ts-nocheck
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type Scalars = {
    Boolean: boolean,
    Int: number,
    String: string,
}

export interface Book {
    author: Scalars['String']
    title: Scalars['String']
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

export interface AuthorInput {name: Scalars['String']}

export interface BookGenqlSelection{
    author?: boolean | number
    title?: boolean | number
    __typename?: boolean | number
    __scalar?: boolean | number
}

export interface BookInput {author: AuthorInput,title: Scalars['String']}

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

export type SubscriptionGenqlSelection = SubscriptionTypeGenqlSelection


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
    