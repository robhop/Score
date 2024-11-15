import { sveltekit } from '@sveltejs/kit/vite';
import { defineConfig } from 'vite';

export default defineConfig({
	plugins: [sveltekit()],
	server:{
		proxy :{
			"/graphql": {
				target: "http://localhost:5095",
				ws: true
			}
		}
	}
});
