<script lang="ts">

    import { createClient, generateSubscriptionOp } from "$lib/generated";

    import { createClient as createWsClient } from "graphql-ws";

    import { onMount } from "svelte";

    onMount(() => {
        const client = createClient({ url: "/graphql" });

        const clientws = createWsClient({
            url: "/graphql",
        });

        let { query, variables } = generateSubscriptionOp({
            bookAdded: {
                title: true,
            },
        });
        console.log("Mounted");

        client.query({ book: { title: true } }).then((result) => {
            console.log(result);
        });

        clientws.subscribe(
            { query, variables },
            {
                next: (data) => console.log(data),
                error: console.error,
                complete: () => console.log("finished"),
            },
        );
    });
</script>

<h1>Welcome to SvelteKit</h1>
<p>
    Visit <a href="https://svelte.dev/docs/kit">svelte.dev/docs/kit</a> to read the
    documentation
</p>
