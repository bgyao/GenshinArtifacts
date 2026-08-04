import { useState } from 'react';

export default function Sidebar({ currentPage, setCurrentPage }) {
    const pages = ["Home", "Test"];

    return (
        <>
            <div className="w-48 h-screen bg-gray-800 text-white flex flex-col">
                <h1 className="text-xl font-bold p-4 border-b border-gray-700">Genshin Artifacts</h1>
                {
                    pages.map((page) => (
                        <button
                            key={page}
                            className={`p-4 text-left hover:bg-gray-700 ${
                                currentPage === page ? 'bg-gray-700' : ''
                            }`}
                            onClick={() => setCurrentPage(page)}
                        >
                            {page}
                        </button>
                    ))
                }
            </div>
        </>
    );
}