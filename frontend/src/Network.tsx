import { useMutation, useQuery } from "@tanstack/react-query";

const BACKEND_URL = import.meta.env.VITE_BACKEND_URL;

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

export type JokeProperties = {
  authorName?: string;
  content: string;
};
const createJoke = async (data: JokeProperties) => {
  const response = await fetch(`${BACKEND_URL}/api/jokes`, {
    method: "POST",
    body: JSON.stringify(data),
  });
  if (response.ok) {
    return true;
  } else {
    throw new Error("Cannot create joke.");
  }
};

export const useCreateJoke = () =>
  useMutation({ mutationFn: (data: JokeProperties) => createJoke(data) });
