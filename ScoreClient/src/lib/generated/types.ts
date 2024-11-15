export default {
    "scalars": [
        1,
        7
    ],
    "types": {
        "Author": {
            "name": [
                1
            ],
            "__typename": [
                1
            ]
        },
        "String": {},
        "Book": {
            "title": [
                1
            ],
            "author": [
                0
            ],
            "__typename": [
                1
            ]
        },
        "Mutation": {
            "addBook": [
                2,
                {
                    "book": [
                        6,
                        "BookInput!"
                    ]
                }
            ],
            "__typename": [
                1
            ]
        },
        "Query": {
            "book": [
                2
            ],
            "__typename": [
                1
            ]
        },
        "AuthorInput": {
            "name": [
                1
            ],
            "__typename": [
                1
            ]
        },
        "BookInput": {
            "title": [
                1
            ],
            "author": [
                5
            ],
            "__typename": [
                1
            ]
        },
        "Boolean": {},
        "Subscription": {
            "bookAdded": [
                2
            ],
            "__typename": [
                1
            ]
        }
    }
}