<script lang="ts">
    import { createClient, generateSubscriptionOp, type Book } from "$lib/generated";

    import { createClient as createWsClient } from "graphql-ws";

    import { onMount } from "svelte";

    $: value = "Hello World";

    onMount(() => {
        const client = createClient({ url: "/graphql" });

        console.log("Mounted");

        client.query({ book: { title: true } }).then((result) => {
            console.log(result);
            if (result) {
                value = result.book.title || "No title";
            }
        });

        const clientws = createWsClient({
            url: "/graphql",
        });

        let { query, variables } = generateSubscriptionOp({
            bookAdded: {
                title: true,
            },
        });

        clientws.subscribe(
            { query, variables: null },
            {
                next: (data) => {
                    console.log(data);
                    if(data.data) {
                        let bn:Book = data.data.bookAdded as Book;
                        console.log(bn.title);
                        value = bn.title;
                    }
                },
                error: console.error,
                complete: () => console.log("finished"),
            },
        );
    })
</script>

<h1>Welcome to Score</h1>
<p>
    {value}
</p>
