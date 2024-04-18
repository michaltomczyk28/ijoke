import { useMutation, useQuery } from "@tanstack/react-query";

const BACKEND_URL = import.meta.env.VITE_BACKEND_URL;

export type JokeServerData = {
  id: string;
  authorName: string;
  content: string;
  createdAt: string;
  votes: number;
};

const fetchJokes = async () => {
  const response = await fetch(`${BACKEND_URL}/api/jokes`);
  if (response.ok) {
    const data = await response.json();
    return data;
  } else {
    throw new Error("Cannot fetch jokes.");
  }
};

export const useGetJokes = () =>
  useQuery({
    queryKey: ["jokes"],
    queryFn: () => fetchJokes(),
  });

export type JokeFormData = { content: string; authorName?: string };

const createJoke = async (data: JokeFormData) => {
  const response = await fetch(`${BACKEND_URL}/api/jokes`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(data),
  });
  if (response.ok) {
    return true;
  } else {
    throw new Error("Cannot create joke.");
  }
};

export const useCreateJoke = () =>
  useMutation({ mutationFn: (data: JokeFormData) => createJoke(data) });
